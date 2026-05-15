#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct InputsOneOf1ItemsOneOf7Content : global::System.IEquatable<InputsOneOf1ItemsOneOf7Content>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? InputsOneOf1ItemsOneOf7Content0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? InputsOneOf1ItemsOneOf7Content0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf7Content0))]
#endif
        public bool IsInputsOneOf1ItemsOneOf7Content0 => InputsOneOf1ItemsOneOf7Content0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputsOneOf1ItemsOneOf7Content0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? value)
        {
            value = InputsOneOf1ItemsOneOf7Content0;
            return IsInputsOneOf1ItemsOneOf7Content0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items> PickInputsOneOf1ItemsOneOf7Content0() => IsInputsOneOf1ItemsOneOf7Content0
            ? InputsOneOf1ItemsOneOf7Content0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1ItemsOneOf7Content0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? InputsOneOf1ItemsOneOf7ContentVariant2 { get; init; }
#else
        public string? InputsOneOf1ItemsOneOf7ContentVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf7ContentVariant2))]
#endif
        public bool IsInputsOneOf1ItemsOneOf7ContentVariant2 => InputsOneOf1ItemsOneOf7ContentVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputsOneOf1ItemsOneOf7ContentVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = InputsOneOf1ItemsOneOf7ContentVariant2;
            return IsInputsOneOf1ItemsOneOf7ContentVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickInputsOneOf1ItemsOneOf7ContentVariant2() => IsInputsOneOf1ItemsOneOf7ContentVariant2
            ? InputsOneOf1ItemsOneOf7ContentVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1ItemsOneOf7ContentVariant2' but the value was {ToString()}.");

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? InputsOneOf1ItemsOneOf7ContentVariant3 { get; init; }
#else
        public object? InputsOneOf1ItemsOneOf7ContentVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(InputsOneOf1ItemsOneOf7ContentVariant3))]
#endif
        public bool IsInputsOneOf1ItemsOneOf7ContentVariant3 => InputsOneOf1ItemsOneOf7ContentVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickInputsOneOf1ItemsOneOf7ContentVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = InputsOneOf1ItemsOneOf7ContentVariant3;
            return IsInputsOneOf1ItemsOneOf7ContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickInputsOneOf1ItemsOneOf7ContentVariant3() => IsInputsOneOf1ItemsOneOf7ContentVariant3
            ? InputsOneOf1ItemsOneOf7ContentVariant3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'InputsOneOf1ItemsOneOf7ContentVariant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator InputsOneOf1ItemsOneOf7Content(string value) => new InputsOneOf1ItemsOneOf7Content((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(InputsOneOf1ItemsOneOf7Content @this) => @this.InputsOneOf1ItemsOneOf7ContentVariant2;

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf7Content(string? value)
        {
            InputsOneOf1ItemsOneOf7ContentVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static InputsOneOf1ItemsOneOf7Content FromInputsOneOf1ItemsOneOf7ContentVariant2(string? value) => new InputsOneOf1ItemsOneOf7Content(value);

        /// <summary>
        /// 
        /// </summary>
        public InputsOneOf1ItemsOneOf7Content(
            global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>? inputsOneOf1ItemsOneOf7Content0,
            string? inputsOneOf1ItemsOneOf7ContentVariant2,
            object? inputsOneOf1ItemsOneOf7ContentVariant3
            )
        {
            InputsOneOf1ItemsOneOf7Content0 = inputsOneOf1ItemsOneOf7Content0;
            InputsOneOf1ItemsOneOf7ContentVariant2 = inputsOneOf1ItemsOneOf7ContentVariant2;
            InputsOneOf1ItemsOneOf7ContentVariant3 = inputsOneOf1ItemsOneOf7ContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            InputsOneOf1ItemsOneOf7ContentVariant3 as object ??
            InputsOneOf1ItemsOneOf7ContentVariant2 as object ??
            InputsOneOf1ItemsOneOf7Content0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            InputsOneOf1ItemsOneOf7Content0?.ToString() ??
            InputsOneOf1ItemsOneOf7ContentVariant2?.ToString() ??
            InputsOneOf1ItemsOneOf7ContentVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsInputsOneOf1ItemsOneOf7Content0 && !IsInputsOneOf1ItemsOneOf7ContentVariant2 && !IsInputsOneOf1ItemsOneOf7ContentVariant3 || !IsInputsOneOf1ItemsOneOf7Content0 && IsInputsOneOf1ItemsOneOf7ContentVariant2 && !IsInputsOneOf1ItemsOneOf7ContentVariant3 || !IsInputsOneOf1ItemsOneOf7Content0 && !IsInputsOneOf1ItemsOneOf7ContentVariant2 && IsInputsOneOf1ItemsOneOf7ContentVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>, TResult>? inputsOneOf1ItemsOneOf7Content0 = null,
            global::System.Func<string, TResult>? inputsOneOf1ItemsOneOf7ContentVariant2 = null,
            global::System.Func<object, TResult>? inputsOneOf1ItemsOneOf7ContentVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsOneOf1ItemsOneOf7Content0 && inputsOneOf1ItemsOneOf7Content0 != null)
            {
                return inputsOneOf1ItemsOneOf7Content0(InputsOneOf1ItemsOneOf7Content0!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant2 && inputsOneOf1ItemsOneOf7ContentVariant2 != null)
            {
                return inputsOneOf1ItemsOneOf7ContentVariant2(InputsOneOf1ItemsOneOf7ContentVariant2!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant3 && inputsOneOf1ItemsOneOf7ContentVariant3 != null)
            {
                return inputsOneOf1ItemsOneOf7ContentVariant3(InputsOneOf1ItemsOneOf7ContentVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>>? inputsOneOf1ItemsOneOf7Content0 = null,

            global::System.Action<string>? inputsOneOf1ItemsOneOf7ContentVariant2 = null,

            global::System.Action<object>? inputsOneOf1ItemsOneOf7ContentVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsOneOf1ItemsOneOf7Content0)
            {
                inputsOneOf1ItemsOneOf7Content0?.Invoke(InputsOneOf1ItemsOneOf7Content0!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant2)
            {
                inputsOneOf1ItemsOneOf7ContentVariant2?.Invoke(InputsOneOf1ItemsOneOf7ContentVariant2!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant3)
            {
                inputsOneOf1ItemsOneOf7ContentVariant3?.Invoke(InputsOneOf1ItemsOneOf7ContentVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>>? inputsOneOf1ItemsOneOf7Content0 = null,
            global::System.Action<string>? inputsOneOf1ItemsOneOf7ContentVariant2 = null,
            global::System.Action<object>? inputsOneOf1ItemsOneOf7ContentVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsInputsOneOf1ItemsOneOf7Content0)
            {
                inputsOneOf1ItemsOneOf7Content0?.Invoke(InputsOneOf1ItemsOneOf7Content0!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant2)
            {
                inputsOneOf1ItemsOneOf7ContentVariant2?.Invoke(InputsOneOf1ItemsOneOf7ContentVariant2!);
            }
            else if (IsInputsOneOf1ItemsOneOf7ContentVariant3)
            {
                inputsOneOf1ItemsOneOf7ContentVariant3?.Invoke(InputsOneOf1ItemsOneOf7ContentVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                InputsOneOf1ItemsOneOf7Content0,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>),
                InputsOneOf1ItemsOneOf7ContentVariant2,
                typeof(string),
                InputsOneOf1ItemsOneOf7ContentVariant3,
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
        public bool Equals(InputsOneOf1ItemsOneOf7Content other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.InputsOneOf1ItemsOneOf7ContentOneOf0Items>?>.Default.Equals(InputsOneOf1ItemsOneOf7Content0, other.InputsOneOf1ItemsOneOf7Content0) &&
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(InputsOneOf1ItemsOneOf7ContentVariant2, other.InputsOneOf1ItemsOneOf7ContentVariant2) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(InputsOneOf1ItemsOneOf7ContentVariant3, other.InputsOneOf1ItemsOneOf7ContentVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(InputsOneOf1ItemsOneOf7Content obj1, InputsOneOf1ItemsOneOf7Content obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<InputsOneOf1ItemsOneOf7Content>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(InputsOneOf1ItemsOneOf7Content obj1, InputsOneOf1ItemsOneOf7Content obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is InputsOneOf1ItemsOneOf7Content o && Equals(o);
        }
    }
}
