#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct InputPricingEntryV2 : global::System.IEquatable<InputPricingEntryV2>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputPricingEntryV2Variant1? InputPricingEntryV2Variant1 { get; init; }
#else
        public global::OpenRouter.InputPricingEntryV2Variant1? InputPricingEntryV2Variant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputPricingEntryV2Variant1))]
#endif
        public bool IsInputPricingEntryV2Variant1 => InputPricingEntryV2Variant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputPricingEntryV2Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputPricingEntryV2Variant1? value)
        {
            value = InputPricingEntryV2Variant1;
            return IsInputPricingEntryV2Variant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputPricingEntryV2Variant1 PickInputPricingEntryV2Variant1() => InputPricingEntryV2Variant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputPricingEntryV2Variant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputPricingEntryV2Variant2? InputPricingEntryV2Variant2 { get; init; }
#else
        public global::OpenRouter.InputPricingEntryV2Variant2? InputPricingEntryV2Variant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputPricingEntryV2Variant2))]
#endif
        public bool IsInputPricingEntryV2Variant2 => InputPricingEntryV2Variant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputPricingEntryV2Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputPricingEntryV2Variant2? value)
        {
            value = InputPricingEntryV2Variant2;
            return IsInputPricingEntryV2Variant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputPricingEntryV2Variant2 PickInputPricingEntryV2Variant2() => InputPricingEntryV2Variant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputPricingEntryV2Variant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.InputPricingEntryV2Variant3? InputPricingEntryV2Variant3 { get; init; }
#else
        public global::OpenRouter.InputPricingEntryV2Variant3? InputPricingEntryV2Variant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputPricingEntryV2Variant3))]
#endif
        public bool IsInputPricingEntryV2Variant3 => InputPricingEntryV2Variant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickInputPricingEntryV2Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.InputPricingEntryV2Variant3? value)
        {
            value = InputPricingEntryV2Variant3;
            return IsInputPricingEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.InputPricingEntryV2Variant3 PickInputPricingEntryV2Variant3() => InputPricingEntryV2Variant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputPricingEntryV2Variant3' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant1 value) => new InputPricingEntryV2((global::OpenRouter.InputPricingEntryV2Variant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputPricingEntryV2Variant1?(InputPricingEntryV2 @this) => @this.InputPricingEntryV2Variant1;

        /// <summary>
        ///
        /// </summary>
        public InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant1? value)
        {
            InputPricingEntryV2Variant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputPricingEntryV2 FromInputPricingEntryV2Variant1(global::OpenRouter.InputPricingEntryV2Variant1? value) => new InputPricingEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant2 value) => new InputPricingEntryV2((global::OpenRouter.InputPricingEntryV2Variant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputPricingEntryV2Variant2?(InputPricingEntryV2 @this) => @this.InputPricingEntryV2Variant2;

        /// <summary>
        ///
        /// </summary>
        public InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant2? value)
        {
            InputPricingEntryV2Variant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputPricingEntryV2 FromInputPricingEntryV2Variant2(global::OpenRouter.InputPricingEntryV2Variant2? value) => new InputPricingEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant3 value) => new InputPricingEntryV2((global::OpenRouter.InputPricingEntryV2Variant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.InputPricingEntryV2Variant3?(InputPricingEntryV2 @this) => @this.InputPricingEntryV2Variant3;

        /// <summary>
        ///
        /// </summary>
        public InputPricingEntryV2(global::OpenRouter.InputPricingEntryV2Variant3? value)
        {
            InputPricingEntryV2Variant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static InputPricingEntryV2 FromInputPricingEntryV2Variant3(global::OpenRouter.InputPricingEntryV2Variant3? value) => new InputPricingEntryV2(value);

        /// <summary>
        ///
        /// </summary>
        public InputPricingEntryV2(
            global::OpenRouter.InputPricingEntryV2Variant1? inputPricingEntryV2Variant1,
            global::OpenRouter.InputPricingEntryV2Variant2? inputPricingEntryV2Variant2,
            global::OpenRouter.InputPricingEntryV2Variant3? inputPricingEntryV2Variant3
            )
        {
            InputPricingEntryV2Variant1 = inputPricingEntryV2Variant1;
            InputPricingEntryV2Variant2 = inputPricingEntryV2Variant2;
            InputPricingEntryV2Variant3 = inputPricingEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            InputPricingEntryV2Variant3 as object ??
            InputPricingEntryV2Variant2 as object ??
            InputPricingEntryV2Variant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            InputPricingEntryV2Variant1?.ToString() ??
            InputPricingEntryV2Variant2?.ToString() ??
            InputPricingEntryV2Variant3?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsInputPricingEntryV2Variant1 && !IsInputPricingEntryV2Variant2 && !IsInputPricingEntryV2Variant3 || !IsInputPricingEntryV2Variant1 && IsInputPricingEntryV2Variant2 && !IsInputPricingEntryV2Variant3 || !IsInputPricingEntryV2Variant1 && !IsInputPricingEntryV2Variant2 && IsInputPricingEntryV2Variant3;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.InputPricingEntryV2Variant1, TResult>? inputPricingEntryV2Variant1 = null,
            global::System.Func<global::OpenRouter.InputPricingEntryV2Variant2, TResult>? inputPricingEntryV2Variant2 = null,
            global::System.Func<global::OpenRouter.InputPricingEntryV2Variant3, TResult>? inputPricingEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputPricingEntryV2Variant1 is { } __value0 && inputPricingEntryV2Variant1 != null)
            {
                return inputPricingEntryV2Variant1(__value0);
            }
            else if (InputPricingEntryV2Variant2 is { } __value1 && inputPricingEntryV2Variant2 != null)
            {
                return inputPricingEntryV2Variant2(__value1);
            }
            else if (InputPricingEntryV2Variant3 is { } __value2 && inputPricingEntryV2Variant3 != null)
            {
                return inputPricingEntryV2Variant3(__value2);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant1>? inputPricingEntryV2Variant1 = null,

            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant2>? inputPricingEntryV2Variant2 = null,

            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant3>? inputPricingEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputPricingEntryV2Variant1 is { } __value0)
            {
                inputPricingEntryV2Variant1?.Invoke(__value0);
            }
            else if (InputPricingEntryV2Variant2 is { } __value1)
            {
                inputPricingEntryV2Variant2?.Invoke(__value1);
            }
            else if (InputPricingEntryV2Variant3 is { } __value2)
            {
                inputPricingEntryV2Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant1>? inputPricingEntryV2Variant1 = null,
            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant2>? inputPricingEntryV2Variant2 = null,
            global::System.Action<global::OpenRouter.InputPricingEntryV2Variant3>? inputPricingEntryV2Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (InputPricingEntryV2Variant1 is { } __value0)
            {
                inputPricingEntryV2Variant1?.Invoke(__value0);
            }
            else if (InputPricingEntryV2Variant2 is { } __value1)
            {
                inputPricingEntryV2Variant2?.Invoke(__value1);
            }
            else if (InputPricingEntryV2Variant3 is { } __value2)
            {
                inputPricingEntryV2Variant3?.Invoke(__value2);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputPricingEntryV2Variant1,
                typeof(global::OpenRouter.InputPricingEntryV2Variant1),
                InputPricingEntryV2Variant2,
                typeof(global::OpenRouter.InputPricingEntryV2Variant2),
                InputPricingEntryV2Variant3,
                typeof(global::OpenRouter.InputPricingEntryV2Variant3),
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
        public bool Equals(InputPricingEntryV2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputPricingEntryV2Variant1?>.Default.Equals(InputPricingEntryV2Variant1, other.InputPricingEntryV2Variant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputPricingEntryV2Variant2?>.Default.Equals(InputPricingEntryV2Variant2, other.InputPricingEntryV2Variant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.InputPricingEntryV2Variant3?>.Default.Equals(InputPricingEntryV2Variant3, other.InputPricingEntryV2Variant3)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(InputPricingEntryV2 obj1, InputPricingEntryV2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputPricingEntryV2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(InputPricingEntryV2 obj1, InputPricingEntryV2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputPricingEntryV2 o && Equals(o);
        }
    }
}
