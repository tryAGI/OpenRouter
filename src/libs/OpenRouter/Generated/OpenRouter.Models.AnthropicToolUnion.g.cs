#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An Anthropic tool definition: a client-defined tool with a JSON Schema `input_schema`, or a server tool (bash, text editor, web search).<br/>
    /// Example: {"description":"Get the current weather for a city.","input_schema":{"properties":{"city":{"type":"string"}},"required":["city"],"type":"object"},"name":"get_weather"}
    /// </summary>
    public readonly partial struct AnthropicToolUnion : global::System.IEquatable<AnthropicToolUnion>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUnionVariant1? AnthropicToolUnionVariant1 { get; init; }
#else
        public global::OpenRouter.AnthropicToolUnionVariant1? AnthropicToolUnionVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUnionVariant1))]
#endif
        public bool IsAnthropicToolUnionVariant1 => AnthropicToolUnionVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicToolUnionVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolUnionVariant1? value)
        {
            value = AnthropicToolUnionVariant1;
            return IsAnthropicToolUnionVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant1 PickAnthropicToolUnionVariant1() => AnthropicToolUnionVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicToolUnionVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUnionVariant2? AnthropicToolUnionVariant2 { get; init; }
#else
        public global::OpenRouter.AnthropicToolUnionVariant2? AnthropicToolUnionVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUnionVariant2))]
#endif
        public bool IsAnthropicToolUnionVariant2 => AnthropicToolUnionVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicToolUnionVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolUnionVariant2? value)
        {
            value = AnthropicToolUnionVariant2;
            return IsAnthropicToolUnionVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant2 PickAnthropicToolUnionVariant2() => AnthropicToolUnionVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicToolUnionVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUnionVariant3? AnthropicToolUnionVariant3 { get; init; }
#else
        public global::OpenRouter.AnthropicToolUnionVariant3? AnthropicToolUnionVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUnionVariant3))]
#endif
        public bool IsAnthropicToolUnionVariant3 => AnthropicToolUnionVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicToolUnionVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolUnionVariant3? value)
        {
            value = AnthropicToolUnionVariant3;
            return IsAnthropicToolUnionVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant3 PickAnthropicToolUnionVariant3() => AnthropicToolUnionVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicToolUnionVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUnionVariant4? AnthropicToolUnionVariant4 { get; init; }
#else
        public global::OpenRouter.AnthropicToolUnionVariant4? AnthropicToolUnionVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUnionVariant4))]
#endif
        public bool IsAnthropicToolUnionVariant4 => AnthropicToolUnionVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicToolUnionVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolUnionVariant4? value)
        {
            value = AnthropicToolUnionVariant4;
            return IsAnthropicToolUnionVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant4 PickAnthropicToolUnionVariant4() => AnthropicToolUnionVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicToolUnionVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicToolUnionVariant5? AnthropicToolUnionVariant5 { get; init; }
#else
        public global::OpenRouter.AnthropicToolUnionVariant5? AnthropicToolUnionVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicToolUnionVariant5))]
#endif
        public bool IsAnthropicToolUnionVariant5 => AnthropicToolUnionVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAnthropicToolUnionVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicToolUnionVariant5? value)
        {
            value = AnthropicToolUnionVariant5;
            return IsAnthropicToolUnionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.AnthropicToolUnionVariant5 PickAnthropicToolUnionVariant5() => AnthropicToolUnionVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicToolUnionVariant5' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant1 value) => new AnthropicToolUnion((global::OpenRouter.AnthropicToolUnionVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUnionVariant1?(AnthropicToolUnion @this) => @this.AnthropicToolUnionVariant1;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant1? value)
        {
            AnthropicToolUnionVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolUnion FromAnthropicToolUnionVariant1(global::OpenRouter.AnthropicToolUnionVariant1? value) => new AnthropicToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant2 value) => new AnthropicToolUnion((global::OpenRouter.AnthropicToolUnionVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUnionVariant2?(AnthropicToolUnion @this) => @this.AnthropicToolUnionVariant2;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant2? value)
        {
            AnthropicToolUnionVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolUnion FromAnthropicToolUnionVariant2(global::OpenRouter.AnthropicToolUnionVariant2? value) => new AnthropicToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant3 value) => new AnthropicToolUnion((global::OpenRouter.AnthropicToolUnionVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUnionVariant3?(AnthropicToolUnion @this) => @this.AnthropicToolUnionVariant3;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant3? value)
        {
            AnthropicToolUnionVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolUnion FromAnthropicToolUnionVariant3(global::OpenRouter.AnthropicToolUnionVariant3? value) => new AnthropicToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant4 value) => new AnthropicToolUnion((global::OpenRouter.AnthropicToolUnionVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUnionVariant4?(AnthropicToolUnion @this) => @this.AnthropicToolUnionVariant4;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant4? value)
        {
            AnthropicToolUnionVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolUnion FromAnthropicToolUnionVariant4(global::OpenRouter.AnthropicToolUnionVariant4? value) => new AnthropicToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant5 value) => new AnthropicToolUnion((global::OpenRouter.AnthropicToolUnionVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicToolUnionVariant5?(AnthropicToolUnion @this) => @this.AnthropicToolUnionVariant5;

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(global::OpenRouter.AnthropicToolUnionVariant5? value)
        {
            AnthropicToolUnionVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static AnthropicToolUnion FromAnthropicToolUnionVariant5(global::OpenRouter.AnthropicToolUnionVariant5? value) => new AnthropicToolUnion(value);

        /// <summary>
        ///
        /// </summary>
        public AnthropicToolUnion(
            global::OpenRouter.AnthropicToolUnionVariant1? anthropicToolUnionVariant1,
            global::OpenRouter.AnthropicToolUnionVariant2? anthropicToolUnionVariant2,
            global::OpenRouter.AnthropicToolUnionVariant3? anthropicToolUnionVariant3,
            global::OpenRouter.AnthropicToolUnionVariant4? anthropicToolUnionVariant4,
            global::OpenRouter.AnthropicToolUnionVariant5? anthropicToolUnionVariant5
            )
        {
            AnthropicToolUnionVariant1 = anthropicToolUnionVariant1;
            AnthropicToolUnionVariant2 = anthropicToolUnionVariant2;
            AnthropicToolUnionVariant3 = anthropicToolUnionVariant3;
            AnthropicToolUnionVariant4 = anthropicToolUnionVariant4;
            AnthropicToolUnionVariant5 = anthropicToolUnionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            AnthropicToolUnionVariant5 as object ??
            AnthropicToolUnionVariant4 as object ??
            AnthropicToolUnionVariant3 as object ??
            AnthropicToolUnionVariant2 as object ??
            AnthropicToolUnionVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            AnthropicToolUnionVariant1?.ToString() ??
            AnthropicToolUnionVariant2?.ToString() ??
            AnthropicToolUnionVariant3?.ToString() ??
            AnthropicToolUnionVariant4?.ToString() ??
            AnthropicToolUnionVariant5?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicToolUnionVariant1 && !IsAnthropicToolUnionVariant2 && !IsAnthropicToolUnionVariant3 && !IsAnthropicToolUnionVariant4 && !IsAnthropicToolUnionVariant5 || !IsAnthropicToolUnionVariant1 && IsAnthropicToolUnionVariant2 && !IsAnthropicToolUnionVariant3 && !IsAnthropicToolUnionVariant4 && !IsAnthropicToolUnionVariant5 || !IsAnthropicToolUnionVariant1 && !IsAnthropicToolUnionVariant2 && IsAnthropicToolUnionVariant3 && !IsAnthropicToolUnionVariant4 && !IsAnthropicToolUnionVariant5 || !IsAnthropicToolUnionVariant1 && !IsAnthropicToolUnionVariant2 && !IsAnthropicToolUnionVariant3 && IsAnthropicToolUnionVariant4 && !IsAnthropicToolUnionVariant5 || !IsAnthropicToolUnionVariant1 && !IsAnthropicToolUnionVariant2 && !IsAnthropicToolUnionVariant3 && !IsAnthropicToolUnionVariant4 && IsAnthropicToolUnionVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicToolUnionVariant1, TResult>? anthropicToolUnionVariant1 = null,
            global::System.Func<global::OpenRouter.AnthropicToolUnionVariant2, TResult>? anthropicToolUnionVariant2 = null,
            global::System.Func<global::OpenRouter.AnthropicToolUnionVariant3, TResult>? anthropicToolUnionVariant3 = null,
            global::System.Func<global::OpenRouter.AnthropicToolUnionVariant4, TResult>? anthropicToolUnionVariant4 = null,
            global::System.Func<global::OpenRouter.AnthropicToolUnionVariant5, TResult>? anthropicToolUnionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicToolUnionVariant1 is { } __value0 && anthropicToolUnionVariant1 != null)
            {
                return anthropicToolUnionVariant1(__value0);
            }
            else if (AnthropicToolUnionVariant2 is { } __value1 && anthropicToolUnionVariant2 != null)
            {
                return anthropicToolUnionVariant2(__value1);
            }
            else if (AnthropicToolUnionVariant3 is { } __value2 && anthropicToolUnionVariant3 != null)
            {
                return anthropicToolUnionVariant3(__value2);
            }
            else if (AnthropicToolUnionVariant4 is { } __value3 && anthropicToolUnionVariant4 != null)
            {
                return anthropicToolUnionVariant4(__value3);
            }
            else if (AnthropicToolUnionVariant5 is { } __value4 && anthropicToolUnionVariant5 != null)
            {
                return anthropicToolUnionVariant5(__value4);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant1>? anthropicToolUnionVariant1 = null,

            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant2>? anthropicToolUnionVariant2 = null,

            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant3>? anthropicToolUnionVariant3 = null,

            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant4>? anthropicToolUnionVariant4 = null,

            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant5>? anthropicToolUnionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicToolUnionVariant1 is { } __value0)
            {
                anthropicToolUnionVariant1?.Invoke(__value0);
            }
            else if (AnthropicToolUnionVariant2 is { } __value1)
            {
                anthropicToolUnionVariant2?.Invoke(__value1);
            }
            else if (AnthropicToolUnionVariant3 is { } __value2)
            {
                anthropicToolUnionVariant3?.Invoke(__value2);
            }
            else if (AnthropicToolUnionVariant4 is { } __value3)
            {
                anthropicToolUnionVariant4?.Invoke(__value3);
            }
            else if (AnthropicToolUnionVariant5 is { } __value4)
            {
                anthropicToolUnionVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant1>? anthropicToolUnionVariant1 = null,
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant2>? anthropicToolUnionVariant2 = null,
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant3>? anthropicToolUnionVariant3 = null,
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant4>? anthropicToolUnionVariant4 = null,
            global::System.Action<global::OpenRouter.AnthropicToolUnionVariant5>? anthropicToolUnionVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (AnthropicToolUnionVariant1 is { } __value0)
            {
                anthropicToolUnionVariant1?.Invoke(__value0);
            }
            else if (AnthropicToolUnionVariant2 is { } __value1)
            {
                anthropicToolUnionVariant2?.Invoke(__value1);
            }
            else if (AnthropicToolUnionVariant3 is { } __value2)
            {
                anthropicToolUnionVariant3?.Invoke(__value2);
            }
            else if (AnthropicToolUnionVariant4 is { } __value3)
            {
                anthropicToolUnionVariant4?.Invoke(__value3);
            }
            else if (AnthropicToolUnionVariant5 is { } __value4)
            {
                anthropicToolUnionVariant5?.Invoke(__value4);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicToolUnionVariant1,
                typeof(global::OpenRouter.AnthropicToolUnionVariant1),
                AnthropicToolUnionVariant2,
                typeof(global::OpenRouter.AnthropicToolUnionVariant2),
                AnthropicToolUnionVariant3,
                typeof(global::OpenRouter.AnthropicToolUnionVariant3),
                AnthropicToolUnionVariant4,
                typeof(global::OpenRouter.AnthropicToolUnionVariant4),
                AnthropicToolUnionVariant5,
                typeof(global::OpenRouter.AnthropicToolUnionVariant5),
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
        public bool Equals(AnthropicToolUnion other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUnionVariant1?>.Default.Equals(AnthropicToolUnionVariant1, other.AnthropicToolUnionVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUnionVariant2?>.Default.Equals(AnthropicToolUnionVariant2, other.AnthropicToolUnionVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUnionVariant3?>.Default.Equals(AnthropicToolUnionVariant3, other.AnthropicToolUnionVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUnionVariant4?>.Default.Equals(AnthropicToolUnionVariant4, other.AnthropicToolUnionVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicToolUnionVariant5?>.Default.Equals(AnthropicToolUnionVariant5, other.AnthropicToolUnionVariant5)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(AnthropicToolUnion obj1, AnthropicToolUnion obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<AnthropicToolUnion>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(AnthropicToolUnion obj1, AnthropicToolUnion obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is AnthropicToolUnion o && Equals(o);
        }
    }
}
