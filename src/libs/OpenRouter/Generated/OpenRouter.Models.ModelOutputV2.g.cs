#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output modality of the endpoint: its `params` (the provider document's `supported_parameters`), pricing, capacity, passthrough parameters and limits<br/>
    /// Example: {"max_length":{"unit":"token","value":4096},"params":{"max_tokens":{"type":"unknown"},"temperature":{"type":"unknown"}},"pricing":[{"cost_usd":"0.00006","type":"completion","unit":"token"}],"type":"text"}
    /// </summary>
    public readonly partial struct ModelOutputV2 : global::System.IEquatable<ModelOutputV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant1? ModelOutputV2Variant1 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant1? ModelOutputV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant1))]
#endif
        public bool IsModelOutputV2Variant1 => ModelOutputV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant1? value)
        {
            value = ModelOutputV2Variant1;
            return IsModelOutputV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant1 PickModelOutputV2Variant1() => ModelOutputV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant2? ModelOutputV2Variant2 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant2? ModelOutputV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant2))]
#endif
        public bool IsModelOutputV2Variant2 => ModelOutputV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant2? value)
        {
            value = ModelOutputV2Variant2;
            return IsModelOutputV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant2 PickModelOutputV2Variant2() => ModelOutputV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant3? ModelOutputV2Variant3 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant3? ModelOutputV2Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant3))]
#endif
        public bool IsModelOutputV2Variant3 => ModelOutputV2Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant3? value)
        {
            value = ModelOutputV2Variant3;
            return IsModelOutputV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant3 PickModelOutputV2Variant3() => ModelOutputV2Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant4? ModelOutputV2Variant4 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant4? ModelOutputV2Variant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant4))]
#endif
        public bool IsModelOutputV2Variant4 => ModelOutputV2Variant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant4? value)
        {
            value = ModelOutputV2Variant4;
            return IsModelOutputV2Variant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant4 PickModelOutputV2Variant4() => ModelOutputV2Variant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant5? ModelOutputV2Variant5 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant5? ModelOutputV2Variant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant5))]
#endif
        public bool IsModelOutputV2Variant5 => ModelOutputV2Variant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant5? value)
        {
            value = ModelOutputV2Variant5;
            return IsModelOutputV2Variant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant5 PickModelOutputV2Variant5() => ModelOutputV2Variant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant5' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant6? ModelOutputV2Variant6 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant6? ModelOutputV2Variant6 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant6))]
#endif
        public bool IsModelOutputV2Variant6 => ModelOutputV2Variant6 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant6? value)
        {
            value = ModelOutputV2Variant6;
            return IsModelOutputV2Variant6;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant6 PickModelOutputV2Variant6() => ModelOutputV2Variant6 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant6' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant7? ModelOutputV2Variant7 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant7? ModelOutputV2Variant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant7))]
#endif
        public bool IsModelOutputV2Variant7 => ModelOutputV2Variant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant7? value)
        {
            value = ModelOutputV2Variant7;
            return IsModelOutputV2Variant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant7 PickModelOutputV2Variant7() => ModelOutputV2Variant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant8? ModelOutputV2Variant8 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant8? ModelOutputV2Variant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant8))]
#endif
        public bool IsModelOutputV2Variant8 => ModelOutputV2Variant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant8? value)
        {
            value = ModelOutputV2Variant8;
            return IsModelOutputV2Variant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant8 PickModelOutputV2Variant8() => ModelOutputV2Variant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant8' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ModelOutputV2Variant9? ModelOutputV2Variant9 { get; init; }
#else
        public global::OpenRouter.ModelOutputV2Variant9? ModelOutputV2Variant9 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ModelOutputV2Variant9))]
#endif
        public bool IsModelOutputV2Variant9 => ModelOutputV2Variant9 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickModelOutputV2Variant9(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ModelOutputV2Variant9? value)
        {
            value = ModelOutputV2Variant9;
            return IsModelOutputV2Variant9;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ModelOutputV2Variant9 PickModelOutputV2Variant9() => ModelOutputV2Variant9 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ModelOutputV2Variant9' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant1 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant1?(ModelOutputV2 @this) => @this.ModelOutputV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant1? value)
        {
            ModelOutputV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant1(global::OpenRouter.ModelOutputV2Variant1? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant2 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant2?(ModelOutputV2 @this) => @this.ModelOutputV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant2? value)
        {
            ModelOutputV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant2(global::OpenRouter.ModelOutputV2Variant2? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant3 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant3?(ModelOutputV2 @this) => @this.ModelOutputV2Variant3;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant3? value)
        {
            ModelOutputV2Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant3(global::OpenRouter.ModelOutputV2Variant3? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant4 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant4?(ModelOutputV2 @this) => @this.ModelOutputV2Variant4;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant4? value)
        {
            ModelOutputV2Variant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant4(global::OpenRouter.ModelOutputV2Variant4? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant5 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant5?(ModelOutputV2 @this) => @this.ModelOutputV2Variant5;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant5? value)
        {
            ModelOutputV2Variant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant5(global::OpenRouter.ModelOutputV2Variant5? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant6 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant6?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant6?(ModelOutputV2 @this) => @this.ModelOutputV2Variant6;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant6? value)
        {
            ModelOutputV2Variant6 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant6(global::OpenRouter.ModelOutputV2Variant6? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant7 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant7?(ModelOutputV2 @this) => @this.ModelOutputV2Variant7;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant7? value)
        {
            ModelOutputV2Variant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant7(global::OpenRouter.ModelOutputV2Variant7? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant8 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant8?(ModelOutputV2 @this) => @this.ModelOutputV2Variant8;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant8? value)
        {
            ModelOutputV2Variant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant8(global::OpenRouter.ModelOutputV2Variant8? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ModelOutputV2(global::OpenRouter.ModelOutputV2Variant9 value) => new ModelOutputV2((global::OpenRouter.ModelOutputV2Variant9?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ModelOutputV2Variant9?(ModelOutputV2 @this) => @this.ModelOutputV2Variant9;

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(global::OpenRouter.ModelOutputV2Variant9? value)
        {
            ModelOutputV2Variant9 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ModelOutputV2 FromModelOutputV2Variant9(global::OpenRouter.ModelOutputV2Variant9? value) => new ModelOutputV2(value);

        /// <summary>
        ///
        /// </summary>
        public ModelOutputV2(
            global::OpenRouter.ModelOutputV2Variant1? modelOutputV2Variant1,
            global::OpenRouter.ModelOutputV2Variant2? modelOutputV2Variant2,
            global::OpenRouter.ModelOutputV2Variant3? modelOutputV2Variant3,
            global::OpenRouter.ModelOutputV2Variant4? modelOutputV2Variant4,
            global::OpenRouter.ModelOutputV2Variant5? modelOutputV2Variant5,
            global::OpenRouter.ModelOutputV2Variant6? modelOutputV2Variant6,
            global::OpenRouter.ModelOutputV2Variant7? modelOutputV2Variant7,
            global::OpenRouter.ModelOutputV2Variant8? modelOutputV2Variant8,
            global::OpenRouter.ModelOutputV2Variant9? modelOutputV2Variant9
            )
        {
            ModelOutputV2Variant1 = modelOutputV2Variant1;
            ModelOutputV2Variant2 = modelOutputV2Variant2;
            ModelOutputV2Variant3 = modelOutputV2Variant3;
            ModelOutputV2Variant4 = modelOutputV2Variant4;
            ModelOutputV2Variant5 = modelOutputV2Variant5;
            ModelOutputV2Variant6 = modelOutputV2Variant6;
            ModelOutputV2Variant7 = modelOutputV2Variant7;
            ModelOutputV2Variant8 = modelOutputV2Variant8;
            ModelOutputV2Variant9 = modelOutputV2Variant9;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            ModelOutputV2Variant9 as object ??
            ModelOutputV2Variant8 as object ??
            ModelOutputV2Variant7 as object ??
            ModelOutputV2Variant6 as object ??
            ModelOutputV2Variant5 as object ??
            ModelOutputV2Variant4 as object ??
            ModelOutputV2Variant3 as object ??
            ModelOutputV2Variant2 as object ??
            ModelOutputV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            ModelOutputV2Variant1?.ToString() ??
            ModelOutputV2Variant2?.ToString() ??
            ModelOutputV2Variant3?.ToString() ??
            ModelOutputV2Variant4?.ToString() ??
            ModelOutputV2Variant5?.ToString() ??
            ModelOutputV2Variant6?.ToString() ??
            ModelOutputV2Variant7?.ToString() ??
            ModelOutputV2Variant8?.ToString() ??
            ModelOutputV2Variant9?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && IsModelOutputV2Variant8 && !IsModelOutputV2Variant9 || !IsModelOutputV2Variant1 && !IsModelOutputV2Variant2 && !IsModelOutputV2Variant3 && !IsModelOutputV2Variant4 && !IsModelOutputV2Variant5 && !IsModelOutputV2Variant6 && !IsModelOutputV2Variant7 && !IsModelOutputV2Variant8 && IsModelOutputV2Variant9;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ModelOutputV2Variant1, TResult>? modelOutputV2Variant1 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant2, TResult>? modelOutputV2Variant2 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant3, TResult>? modelOutputV2Variant3 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant4, TResult>? modelOutputV2Variant4 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant5, TResult>? modelOutputV2Variant5 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant6, TResult>? modelOutputV2Variant6 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant7, TResult>? modelOutputV2Variant7 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant8, TResult>? modelOutputV2Variant8 = null,
            global::System.Func<global::OpenRouter.ModelOutputV2Variant9, TResult>? modelOutputV2Variant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelOutputV2Variant1 is { } __value0 && modelOutputV2Variant1 != null)
            {
                return modelOutputV2Variant1(__value0);
            }
            else if (ModelOutputV2Variant2 is { } __value1 && modelOutputV2Variant2 != null)
            {
                return modelOutputV2Variant2(__value1);
            }
            else if (ModelOutputV2Variant3 is { } __value2 && modelOutputV2Variant3 != null)
            {
                return modelOutputV2Variant3(__value2);
            }
            else if (ModelOutputV2Variant4 is { } __value3 && modelOutputV2Variant4 != null)
            {
                return modelOutputV2Variant4(__value3);
            }
            else if (ModelOutputV2Variant5 is { } __value4 && modelOutputV2Variant5 != null)
            {
                return modelOutputV2Variant5(__value4);
            }
            else if (ModelOutputV2Variant6 is { } __value5 && modelOutputV2Variant6 != null)
            {
                return modelOutputV2Variant6(__value5);
            }
            else if (ModelOutputV2Variant7 is { } __value6 && modelOutputV2Variant7 != null)
            {
                return modelOutputV2Variant7(__value6);
            }
            else if (ModelOutputV2Variant8 is { } __value7 && modelOutputV2Variant8 != null)
            {
                return modelOutputV2Variant8(__value7);
            }
            else if (ModelOutputV2Variant9 is { } __value8 && modelOutputV2Variant9 != null)
            {
                return modelOutputV2Variant9(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ModelOutputV2Variant1>? modelOutputV2Variant1 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant2>? modelOutputV2Variant2 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant3>? modelOutputV2Variant3 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant4>? modelOutputV2Variant4 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant5>? modelOutputV2Variant5 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant6>? modelOutputV2Variant6 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant7>? modelOutputV2Variant7 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant8>? modelOutputV2Variant8 = null,

            global::System.Action<global::OpenRouter.ModelOutputV2Variant9>? modelOutputV2Variant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelOutputV2Variant1 is { } __value0)
            {
                modelOutputV2Variant1?.Invoke(__value0);
            }
            else if (ModelOutputV2Variant2 is { } __value1)
            {
                modelOutputV2Variant2?.Invoke(__value1);
            }
            else if (ModelOutputV2Variant3 is { } __value2)
            {
                modelOutputV2Variant3?.Invoke(__value2);
            }
            else if (ModelOutputV2Variant4 is { } __value3)
            {
                modelOutputV2Variant4?.Invoke(__value3);
            }
            else if (ModelOutputV2Variant5 is { } __value4)
            {
                modelOutputV2Variant5?.Invoke(__value4);
            }
            else if (ModelOutputV2Variant6 is { } __value5)
            {
                modelOutputV2Variant6?.Invoke(__value5);
            }
            else if (ModelOutputV2Variant7 is { } __value6)
            {
                modelOutputV2Variant7?.Invoke(__value6);
            }
            else if (ModelOutputV2Variant8 is { } __value7)
            {
                modelOutputV2Variant8?.Invoke(__value7);
            }
            else if (ModelOutputV2Variant9 is { } __value8)
            {
                modelOutputV2Variant9?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ModelOutputV2Variant1>? modelOutputV2Variant1 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant2>? modelOutputV2Variant2 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant3>? modelOutputV2Variant3 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant4>? modelOutputV2Variant4 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant5>? modelOutputV2Variant5 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant6>? modelOutputV2Variant6 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant7>? modelOutputV2Variant7 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant8>? modelOutputV2Variant8 = null,
            global::System.Action<global::OpenRouter.ModelOutputV2Variant9>? modelOutputV2Variant9 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (ModelOutputV2Variant1 is { } __value0)
            {
                modelOutputV2Variant1?.Invoke(__value0);
            }
            else if (ModelOutputV2Variant2 is { } __value1)
            {
                modelOutputV2Variant2?.Invoke(__value1);
            }
            else if (ModelOutputV2Variant3 is { } __value2)
            {
                modelOutputV2Variant3?.Invoke(__value2);
            }
            else if (ModelOutputV2Variant4 is { } __value3)
            {
                modelOutputV2Variant4?.Invoke(__value3);
            }
            else if (ModelOutputV2Variant5 is { } __value4)
            {
                modelOutputV2Variant5?.Invoke(__value4);
            }
            else if (ModelOutputV2Variant6 is { } __value5)
            {
                modelOutputV2Variant6?.Invoke(__value5);
            }
            else if (ModelOutputV2Variant7 is { } __value6)
            {
                modelOutputV2Variant7?.Invoke(__value6);
            }
            else if (ModelOutputV2Variant8 is { } __value7)
            {
                modelOutputV2Variant8?.Invoke(__value7);
            }
            else if (ModelOutputV2Variant9 is { } __value8)
            {
                modelOutputV2Variant9?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ModelOutputV2Variant1,
                typeof(global::OpenRouter.ModelOutputV2Variant1),
                ModelOutputV2Variant2,
                typeof(global::OpenRouter.ModelOutputV2Variant2),
                ModelOutputV2Variant3,
                typeof(global::OpenRouter.ModelOutputV2Variant3),
                ModelOutputV2Variant4,
                typeof(global::OpenRouter.ModelOutputV2Variant4),
                ModelOutputV2Variant5,
                typeof(global::OpenRouter.ModelOutputV2Variant5),
                ModelOutputV2Variant6,
                typeof(global::OpenRouter.ModelOutputV2Variant6),
                ModelOutputV2Variant7,
                typeof(global::OpenRouter.ModelOutputV2Variant7),
                ModelOutputV2Variant8,
                typeof(global::OpenRouter.ModelOutputV2Variant8),
                ModelOutputV2Variant9,
                typeof(global::OpenRouter.ModelOutputV2Variant9),
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
        public bool Equals(ModelOutputV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant1?>.Default.Equals(ModelOutputV2Variant1, other.ModelOutputV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant2?>.Default.Equals(ModelOutputV2Variant2, other.ModelOutputV2Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant3?>.Default.Equals(ModelOutputV2Variant3, other.ModelOutputV2Variant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant4?>.Default.Equals(ModelOutputV2Variant4, other.ModelOutputV2Variant4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant5?>.Default.Equals(ModelOutputV2Variant5, other.ModelOutputV2Variant5) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant6?>.Default.Equals(ModelOutputV2Variant6, other.ModelOutputV2Variant6) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant7?>.Default.Equals(ModelOutputV2Variant7, other.ModelOutputV2Variant7) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant8?>.Default.Equals(ModelOutputV2Variant8, other.ModelOutputV2Variant8) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ModelOutputV2Variant9?>.Default.Equals(ModelOutputV2Variant9, other.ModelOutputV2Variant9)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ModelOutputV2 obj1, ModelOutputV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ModelOutputV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ModelOutputV2 obj1, ModelOutputV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ModelOutputV2 o && Equals(o);
        }
    }
}
