#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Example: auto
    /// </summary>
    public readonly partial struct OpenAIResponsesToolChoice : global::System.IEquatable<OpenAIResponsesToolChoice>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1? OpenAIResponsesToolChoiceVariant1 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1? OpenAIResponsesToolChoiceVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant1))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant1 => OpenAIResponsesToolChoiceVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant1? value)
        {
            value = OpenAIResponsesToolChoiceVariant1;
            return IsOpenAIResponsesToolChoiceVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant1 PickOpenAIResponsesToolChoiceVariant1() => OpenAIResponsesToolChoiceVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2? OpenAIResponsesToolChoiceVariant2 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2? OpenAIResponsesToolChoiceVariant2 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant2))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant2 => OpenAIResponsesToolChoiceVariant2 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant2? value)
        {
            value = OpenAIResponsesToolChoiceVariant2;
            return IsOpenAIResponsesToolChoiceVariant2;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant2 PickOpenAIResponsesToolChoiceVariant2() => OpenAIResponsesToolChoiceVariant2 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant2' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3? OpenAIResponsesToolChoiceVariant3 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3? OpenAIResponsesToolChoiceVariant3 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant3))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant3 => OpenAIResponsesToolChoiceVariant3 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant3? value)
        {
            value = OpenAIResponsesToolChoiceVariant3;
            return IsOpenAIResponsesToolChoiceVariant3;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant3 PickOpenAIResponsesToolChoiceVariant3() => OpenAIResponsesToolChoiceVariant3 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant3' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4? OpenAIResponsesToolChoiceVariant4 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4? OpenAIResponsesToolChoiceVariant4 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant4))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant4 => OpenAIResponsesToolChoiceVariant4 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant4? value)
        {
            value = OpenAIResponsesToolChoiceVariant4;
            return IsOpenAIResponsesToolChoiceVariant4;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant4 PickOpenAIResponsesToolChoiceVariant4() => OpenAIResponsesToolChoiceVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant4' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5? OpenAIResponsesToolChoiceVariant5 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5? OpenAIResponsesToolChoiceVariant5 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant5))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant5 => OpenAIResponsesToolChoiceVariant5 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant5? value)
        {
            value = OpenAIResponsesToolChoiceVariant5;
            return IsOpenAIResponsesToolChoiceVariant5;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant5 PickOpenAIResponsesToolChoiceVariant5() => OpenAIResponsesToolChoiceVariant5 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant5' but the value was {ToString()}.");

        /// <summary>
        /// Constrains the model to a pre-defined set of allowed tools<br/>
        /// Example: {"mode":"auto","tools":[{"name":"get_weather","type":"function"}],"type":"allowed_tools"}
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ToolChoiceAllowed? Allowed { get; init; }
#else
        public global::OpenRouter.ToolChoiceAllowed? Allowed { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Allowed))]
#endif
        public bool IsAllowed => Allowed != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAllowed(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ToolChoiceAllowed? value)
        {
            value = Allowed;
            return IsAllowed;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ToolChoiceAllowed PickAllowed() => Allowed is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Allowed' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7? OpenAIResponsesToolChoiceVariant7 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7? OpenAIResponsesToolChoiceVariant7 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant7))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant7 => OpenAIResponsesToolChoiceVariant7 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant7? value)
        {
            value = OpenAIResponsesToolChoiceVariant7;
            return IsOpenAIResponsesToolChoiceVariant7;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant7 PickOpenAIResponsesToolChoiceVariant7() => OpenAIResponsesToolChoiceVariant7 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant7' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8? OpenAIResponsesToolChoiceVariant8 { get; init; }
#else
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8? OpenAIResponsesToolChoiceVariant8 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponsesToolChoiceVariant8))]
#endif
        public bool IsOpenAIResponsesToolChoiceVariant8 => OpenAIResponsesToolChoiceVariant8 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickOpenAIResponsesToolChoiceVariant8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.OpenAIResponsesToolChoiceVariant8? value)
        {
            value = OpenAIResponsesToolChoiceVariant8;
            return IsOpenAIResponsesToolChoiceVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.OpenAIResponsesToolChoiceVariant8 PickOpenAIResponsesToolChoiceVariant8() => OpenAIResponsesToolChoiceVariant8 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'OpenAIResponsesToolChoiceVariant8' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant1 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant1?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant1?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant1;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant1? value)
        {
            OpenAIResponsesToolChoiceVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant1(global::OpenRouter.OpenAIResponsesToolChoiceVariant1? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant2 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant2?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant2?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant2;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant2? value)
        {
            OpenAIResponsesToolChoiceVariant2 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant2(global::OpenRouter.OpenAIResponsesToolChoiceVariant2? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant3 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant3?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant3?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant3;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant3? value)
        {
            OpenAIResponsesToolChoiceVariant3 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant3(global::OpenRouter.OpenAIResponsesToolChoiceVariant3? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant4 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant4?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant4?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant4;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant4? value)
        {
            OpenAIResponsesToolChoiceVariant4 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant4(global::OpenRouter.OpenAIResponsesToolChoiceVariant4? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant5 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant5?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant5?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant5;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant5? value)
        {
            OpenAIResponsesToolChoiceVariant5 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant5(global::OpenRouter.OpenAIResponsesToolChoiceVariant5? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.ToolChoiceAllowed value) => new OpenAIResponsesToolChoice((global::OpenRouter.ToolChoiceAllowed?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ToolChoiceAllowed?(OpenAIResponsesToolChoice @this) => @this.Allowed;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.ToolChoiceAllowed? value)
        {
            Allowed = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromAllowed(global::OpenRouter.ToolChoiceAllowed? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant7 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant7?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant7?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant7;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant7? value)
        {
            OpenAIResponsesToolChoiceVariant7 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant7(global::OpenRouter.OpenAIResponsesToolChoiceVariant7? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant8 value) => new OpenAIResponsesToolChoice((global::OpenRouter.OpenAIResponsesToolChoiceVariant8?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponsesToolChoiceVariant8?(OpenAIResponsesToolChoice @this) => @this.OpenAIResponsesToolChoiceVariant8;

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(global::OpenRouter.OpenAIResponsesToolChoiceVariant8? value)
        {
            OpenAIResponsesToolChoiceVariant8 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static OpenAIResponsesToolChoice FromOpenAIResponsesToolChoiceVariant8(global::OpenRouter.OpenAIResponsesToolChoiceVariant8? value) => new OpenAIResponsesToolChoice(value);

        /// <summary>
        ///
        /// </summary>
        public OpenAIResponsesToolChoice(
            global::OpenRouter.OpenAIResponsesToolChoiceVariant1? openAIResponsesToolChoiceVariant1,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant2? openAIResponsesToolChoiceVariant2,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant3? openAIResponsesToolChoiceVariant3,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant4? openAIResponsesToolChoiceVariant4,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant5? openAIResponsesToolChoiceVariant5,
            global::OpenRouter.ToolChoiceAllowed? allowed,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant7? openAIResponsesToolChoiceVariant7,
            global::OpenRouter.OpenAIResponsesToolChoiceVariant8? openAIResponsesToolChoiceVariant8
            )
        {
            OpenAIResponsesToolChoiceVariant1 = openAIResponsesToolChoiceVariant1;
            OpenAIResponsesToolChoiceVariant2 = openAIResponsesToolChoiceVariant2;
            OpenAIResponsesToolChoiceVariant3 = openAIResponsesToolChoiceVariant3;
            OpenAIResponsesToolChoiceVariant4 = openAIResponsesToolChoiceVariant4;
            OpenAIResponsesToolChoiceVariant5 = openAIResponsesToolChoiceVariant5;
            Allowed = allowed;
            OpenAIResponsesToolChoiceVariant7 = openAIResponsesToolChoiceVariant7;
            OpenAIResponsesToolChoiceVariant8 = openAIResponsesToolChoiceVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            OpenAIResponsesToolChoiceVariant8 as object ??
            OpenAIResponsesToolChoiceVariant7 as object ??
            Allowed as object ??
            OpenAIResponsesToolChoiceVariant5 as object ??
            OpenAIResponsesToolChoiceVariant4 as object ??
            OpenAIResponsesToolChoiceVariant3 as object ??
            OpenAIResponsesToolChoiceVariant2 as object ??
            OpenAIResponsesToolChoiceVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            OpenAIResponsesToolChoiceVariant1?.ToValueString() ??
            OpenAIResponsesToolChoiceVariant2?.ToValueString() ??
            OpenAIResponsesToolChoiceVariant3?.ToValueString() ??
            OpenAIResponsesToolChoiceVariant4?.ToString() ??
            OpenAIResponsesToolChoiceVariant5?.ToString() ??
            Allowed?.ToString() ??
            OpenAIResponsesToolChoiceVariant7?.ToString() ??
            OpenAIResponsesToolChoiceVariant8?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsOpenAIResponsesToolChoiceVariant1 || IsOpenAIResponsesToolChoiceVariant2 || IsOpenAIResponsesToolChoiceVariant3 || IsOpenAIResponsesToolChoiceVariant4 || IsOpenAIResponsesToolChoiceVariant5 || IsAllowed || IsOpenAIResponsesToolChoiceVariant7 || IsOpenAIResponsesToolChoiceVariant8;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant1?, TResult>? openAIResponsesToolChoiceVariant1 = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant2?, TResult>? openAIResponsesToolChoiceVariant2 = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant3?, TResult>? openAIResponsesToolChoiceVariant3 = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant4, TResult>? openAIResponsesToolChoiceVariant4 = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant5, TResult>? openAIResponsesToolChoiceVariant5 = null,
            global::System.Func<global::OpenRouter.ToolChoiceAllowed, TResult>? allowed = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant7, TResult>? openAIResponsesToolChoiceVariant7 = null,
            global::System.Func<global::OpenRouter.OpenAIResponsesToolChoiceVariant8, TResult>? openAIResponsesToolChoiceVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponsesToolChoiceVariant1 is { } __value0 && openAIResponsesToolChoiceVariant1 != null)
            {
                return openAIResponsesToolChoiceVariant1(__value0);
            }
            else if (OpenAIResponsesToolChoiceVariant2 is { } __value1 && openAIResponsesToolChoiceVariant2 != null)
            {
                return openAIResponsesToolChoiceVariant2(__value1);
            }
            else if (OpenAIResponsesToolChoiceVariant3 is { } __value2 && openAIResponsesToolChoiceVariant3 != null)
            {
                return openAIResponsesToolChoiceVariant3(__value2);
            }
            else if (OpenAIResponsesToolChoiceVariant4 is { } __value3 && openAIResponsesToolChoiceVariant4 != null)
            {
                return openAIResponsesToolChoiceVariant4(__value3);
            }
            else if (OpenAIResponsesToolChoiceVariant5 is { } __value4 && openAIResponsesToolChoiceVariant5 != null)
            {
                return openAIResponsesToolChoiceVariant5(__value4);
            }
            else if (Allowed is { } __value5 && allowed != null)
            {
                return allowed(__value5);
            }
            else if (OpenAIResponsesToolChoiceVariant7 is { } __value6 && openAIResponsesToolChoiceVariant7 != null)
            {
                return openAIResponsesToolChoiceVariant7(__value6);
            }
            else if (OpenAIResponsesToolChoiceVariant8 is { } __value7 && openAIResponsesToolChoiceVariant8 != null)
            {
                return openAIResponsesToolChoiceVariant8(__value7);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant1?>? openAIResponsesToolChoiceVariant1 = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant2?>? openAIResponsesToolChoiceVariant2 = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant3?>? openAIResponsesToolChoiceVariant3 = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant4>? openAIResponsesToolChoiceVariant4 = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant5>? openAIResponsesToolChoiceVariant5 = null,

            global::System.Action<global::OpenRouter.ToolChoiceAllowed>? allowed = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant7>? openAIResponsesToolChoiceVariant7 = null,

            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant8>? openAIResponsesToolChoiceVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponsesToolChoiceVariant1 is { } __value0)
            {
                openAIResponsesToolChoiceVariant1?.Invoke(__value0);
            }
            else if (OpenAIResponsesToolChoiceVariant2 is { } __value1)
            {
                openAIResponsesToolChoiceVariant2?.Invoke(__value1);
            }
            else if (OpenAIResponsesToolChoiceVariant3 is { } __value2)
            {
                openAIResponsesToolChoiceVariant3?.Invoke(__value2);
            }
            else if (OpenAIResponsesToolChoiceVariant4 is { } __value3)
            {
                openAIResponsesToolChoiceVariant4?.Invoke(__value3);
            }
            else if (OpenAIResponsesToolChoiceVariant5 is { } __value4)
            {
                openAIResponsesToolChoiceVariant5?.Invoke(__value4);
            }
            else if (Allowed is { } __value5)
            {
                allowed?.Invoke(__value5);
            }
            else if (OpenAIResponsesToolChoiceVariant7 is { } __value6)
            {
                openAIResponsesToolChoiceVariant7?.Invoke(__value6);
            }
            else if (OpenAIResponsesToolChoiceVariant8 is { } __value7)
            {
                openAIResponsesToolChoiceVariant8?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant1?>? openAIResponsesToolChoiceVariant1 = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant2?>? openAIResponsesToolChoiceVariant2 = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant3?>? openAIResponsesToolChoiceVariant3 = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant4>? openAIResponsesToolChoiceVariant4 = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant5>? openAIResponsesToolChoiceVariant5 = null,
            global::System.Action<global::OpenRouter.ToolChoiceAllowed>? allowed = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant7>? openAIResponsesToolChoiceVariant7 = null,
            global::System.Action<global::OpenRouter.OpenAIResponsesToolChoiceVariant8>? openAIResponsesToolChoiceVariant8 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (OpenAIResponsesToolChoiceVariant1 is { } __value0)
            {
                openAIResponsesToolChoiceVariant1?.Invoke(__value0);
            }
            else if (OpenAIResponsesToolChoiceVariant2 is { } __value1)
            {
                openAIResponsesToolChoiceVariant2?.Invoke(__value1);
            }
            else if (OpenAIResponsesToolChoiceVariant3 is { } __value2)
            {
                openAIResponsesToolChoiceVariant3?.Invoke(__value2);
            }
            else if (OpenAIResponsesToolChoiceVariant4 is { } __value3)
            {
                openAIResponsesToolChoiceVariant4?.Invoke(__value3);
            }
            else if (OpenAIResponsesToolChoiceVariant5 is { } __value4)
            {
                openAIResponsesToolChoiceVariant5?.Invoke(__value4);
            }
            else if (Allowed is { } __value5)
            {
                allowed?.Invoke(__value5);
            }
            else if (OpenAIResponsesToolChoiceVariant7 is { } __value6)
            {
                openAIResponsesToolChoiceVariant7?.Invoke(__value6);
            }
            else if (OpenAIResponsesToolChoiceVariant8 is { } __value7)
            {
                openAIResponsesToolChoiceVariant8?.Invoke(__value7);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OpenAIResponsesToolChoiceVariant1,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant1),
                OpenAIResponsesToolChoiceVariant2,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant2),
                OpenAIResponsesToolChoiceVariant3,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant3),
                OpenAIResponsesToolChoiceVariant4,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant4),
                OpenAIResponsesToolChoiceVariant5,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant5),
                Allowed,
                typeof(global::OpenRouter.ToolChoiceAllowed),
                OpenAIResponsesToolChoiceVariant7,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant7),
                OpenAIResponsesToolChoiceVariant8,
                typeof(global::OpenRouter.OpenAIResponsesToolChoiceVariant8),
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
        public bool Equals(OpenAIResponsesToolChoice other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant1?>.Default.Equals(OpenAIResponsesToolChoiceVariant1, other.OpenAIResponsesToolChoiceVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant2?>.Default.Equals(OpenAIResponsesToolChoiceVariant2, other.OpenAIResponsesToolChoiceVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant3?>.Default.Equals(OpenAIResponsesToolChoiceVariant3, other.OpenAIResponsesToolChoiceVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant4?>.Default.Equals(OpenAIResponsesToolChoiceVariant4, other.OpenAIResponsesToolChoiceVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant5?>.Default.Equals(OpenAIResponsesToolChoiceVariant5, other.OpenAIResponsesToolChoiceVariant5) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ToolChoiceAllowed?>.Default.Equals(Allowed, other.Allowed) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant7?>.Default.Equals(OpenAIResponsesToolChoiceVariant7, other.OpenAIResponsesToolChoiceVariant7) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponsesToolChoiceVariant8?>.Default.Equals(OpenAIResponsesToolChoiceVariant8, other.OpenAIResponsesToolChoiceVariant8)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(OpenAIResponsesToolChoice obj1, OpenAIResponsesToolChoice obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAIResponsesToolChoice>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(OpenAIResponsesToolChoice obj1, OpenAIResponsesToolChoice obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAIResponsesToolChoice o && Equals(o);
        }
    }
}
