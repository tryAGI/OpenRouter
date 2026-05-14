#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1Items : global::System.IEquatable<MessagesMessageParamContentOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicTextBlockParam? AnthropicTextBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicTextBlockParam? AnthropicTextBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicTextBlockParam))]
#endif
        public bool IsAnthropicTextBlockParam => AnthropicTextBlockParam != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicTextBlockParam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicTextBlockParam? value)
        {
            value = AnthropicTextBlockParam;
            return IsAnthropicTextBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicTextBlockParam PickAnthropicTextBlockParam() => IsAnthropicTextBlockParam
            ? AnthropicTextBlockParam!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicTextBlockParam' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicImageBlockParam? AnthropicImageBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicImageBlockParam? AnthropicImageBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicImageBlockParam))]
#endif
        public bool IsAnthropicImageBlockParam => AnthropicImageBlockParam != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicImageBlockParam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicImageBlockParam? value)
        {
            value = AnthropicImageBlockParam;
            return IsAnthropicImageBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicImageBlockParam PickAnthropicImageBlockParam() => IsAnthropicImageBlockParam
            ? AnthropicImageBlockParam!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicImageBlockParam' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicDocumentBlockParam? AnthropicDocumentBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicDocumentBlockParam? AnthropicDocumentBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicDocumentBlockParam))]
#endif
        public bool IsAnthropicDocumentBlockParam => AnthropicDocumentBlockParam != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicDocumentBlockParam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicDocumentBlockParam? value)
        {
            value = AnthropicDocumentBlockParam;
            return IsAnthropicDocumentBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicDocumentBlockParam PickAnthropicDocumentBlockParam() => IsAnthropicDocumentBlockParam
            ? AnthropicDocumentBlockParam!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicDocumentBlockParam' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items3? MessagesMessageParamContentOneOf1Items3 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items3? MessagesMessageParamContentOneOf1Items3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items3))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items3 => MessagesMessageParamContentOneOf1Items3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items3? value)
        {
            value = MessagesMessageParamContentOneOf1Items3;
            return IsMessagesMessageParamContentOneOf1Items3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items3 PickMessagesMessageParamContentOneOf1Items3() => IsMessagesMessageParamContentOneOf1Items3
            ? MessagesMessageParamContentOneOf1Items3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items4? MessagesMessageParamContentOneOf1Items4 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items4? MessagesMessageParamContentOneOf1Items4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items4))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items4 => MessagesMessageParamContentOneOf1Items4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items4? value)
        {
            value = MessagesMessageParamContentOneOf1Items4;
            return IsMessagesMessageParamContentOneOf1Items4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items4 PickMessagesMessageParamContentOneOf1Items4() => IsMessagesMessageParamContentOneOf1Items4
            ? MessagesMessageParamContentOneOf1Items4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items5? MessagesMessageParamContentOneOf1Items5 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items5? MessagesMessageParamContentOneOf1Items5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items5))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items5 => MessagesMessageParamContentOneOf1Items5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items5? value)
        {
            value = MessagesMessageParamContentOneOf1Items5;
            return IsMessagesMessageParamContentOneOf1Items5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items5 PickMessagesMessageParamContentOneOf1Items5() => IsMessagesMessageParamContentOneOf1Items5
            ? MessagesMessageParamContentOneOf1Items5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items5' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items6? MessagesMessageParamContentOneOf1Items6 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items6? MessagesMessageParamContentOneOf1Items6 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items6))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items6 => MessagesMessageParamContentOneOf1Items6 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items6(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items6? value)
        {
            value = MessagesMessageParamContentOneOf1Items6;
            return IsMessagesMessageParamContentOneOf1Items6;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items6 PickMessagesMessageParamContentOneOf1Items6() => IsMessagesMessageParamContentOneOf1Items6
            ? MessagesMessageParamContentOneOf1Items6!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items6' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items7? MessagesMessageParamContentOneOf1Items7 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items7? MessagesMessageParamContentOneOf1Items7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items7))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items7 => MessagesMessageParamContentOneOf1Items7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items7? value)
        {
            value = MessagesMessageParamContentOneOf1Items7;
            return IsMessagesMessageParamContentOneOf1Items7;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items7 PickMessagesMessageParamContentOneOf1Items7() => IsMessagesMessageParamContentOneOf1Items7
            ? MessagesMessageParamContentOneOf1Items7!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items7' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items8? MessagesMessageParamContentOneOf1Items8 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items8? MessagesMessageParamContentOneOf1Items8 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items8))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items8 => MessagesMessageParamContentOneOf1Items8 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items8(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items8? value)
        {
            value = MessagesMessageParamContentOneOf1Items8;
            return IsMessagesMessageParamContentOneOf1Items8;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items8 PickMessagesMessageParamContentOneOf1Items8() => IsMessagesMessageParamContentOneOf1Items8
            ? MessagesMessageParamContentOneOf1Items8!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items8' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicSearchResultBlockParam? AnthropicSearchResultBlockParam { get; init; }
#else
        public global::OpenRouter.AnthropicSearchResultBlockParam? AnthropicSearchResultBlockParam { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicSearchResultBlockParam))]
#endif
        public bool IsAnthropicSearchResultBlockParam => AnthropicSearchResultBlockParam != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicSearchResultBlockParam(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicSearchResultBlockParam? value)
        {
            value = AnthropicSearchResultBlockParam;
            return IsAnthropicSearchResultBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicSearchResultBlockParam PickAnthropicSearchResultBlockParam() => IsAnthropicSearchResultBlockParam
            ? AnthropicSearchResultBlockParam!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicSearchResultBlockParam' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items10? MessagesMessageParamContentOneOf1Items10 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items10? MessagesMessageParamContentOneOf1Items10 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1Items10))]
#endif
        public bool IsMessagesMessageParamContentOneOf1Items10 => MessagesMessageParamContentOneOf1Items10 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1Items10(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1Items10? value)
        {
            value = MessagesMessageParamContentOneOf1Items10;
            return IsMessagesMessageParamContentOneOf1Items10;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1Items10 PickMessagesMessageParamContentOneOf1Items10() => IsMessagesMessageParamContentOneOf1Items10
            ? MessagesMessageParamContentOneOf1Items10!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1Items10' but the value was {ToString()}.");

        /// <summary>
        /// Advisor tool result from a prior assistant turn, replayed back to the model on the next turn. Mirrors the block Anthropic returns in assistant content when the `advisor_20260301` tool runs.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.MessagesAdvisorToolResultBlock? MessagesAdvisorToolResultBlock { get; init; }
#else
        public global::OpenRouter.MessagesAdvisorToolResultBlock? MessagesAdvisorToolResultBlock { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesAdvisorToolResultBlock))]
#endif
        public bool IsMessagesAdvisorToolResultBlock => MessagesAdvisorToolResultBlock != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesAdvisorToolResultBlock(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesAdvisorToolResultBlock? value)
        {
            value = MessagesAdvisorToolResultBlock;
            return IsMessagesAdvisorToolResultBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesAdvisorToolResultBlock PickMessagesAdvisorToolResultBlock() => IsMessagesAdvisorToolResultBlock
            ? MessagesAdvisorToolResultBlock!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesAdvisorToolResultBlock' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.AnthropicTextBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParam?(MessagesMessageParamContentOneOf1Items @this) => @this.AnthropicTextBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam? value)
        {
            AnthropicTextBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromAnthropicTextBlockParam(global::OpenRouter.AnthropicTextBlockParam? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.AnthropicImageBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParam?(MessagesMessageParamContentOneOf1Items @this) => @this.AnthropicImageBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam? value)
        {
            AnthropicImageBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromAnthropicImageBlockParam(global::OpenRouter.AnthropicImageBlockParam? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParam value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.AnthropicDocumentBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDocumentBlockParam?(MessagesMessageParamContentOneOf1Items @this) => @this.AnthropicDocumentBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParam? value)
        {
            AnthropicDocumentBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromAnthropicDocumentBlockParam(global::OpenRouter.AnthropicDocumentBlockParam? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items3 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items3?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items3;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items3? value)
        {
            MessagesMessageParamContentOneOf1Items3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items3(global::OpenRouter.MessagesMessageParamContentOneOf1Items3? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items4 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items4?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items4;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items4? value)
        {
            MessagesMessageParamContentOneOf1Items4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items4(global::OpenRouter.MessagesMessageParamContentOneOf1Items4? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items5 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items5?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items5;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items5? value)
        {
            MessagesMessageParamContentOneOf1Items5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items5(global::OpenRouter.MessagesMessageParamContentOneOf1Items5? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items6 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items6?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items6;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items6? value)
        {
            MessagesMessageParamContentOneOf1Items6 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items6(global::OpenRouter.MessagesMessageParamContentOneOf1Items6? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items7 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items7?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items7;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items7? value)
        {
            MessagesMessageParamContentOneOf1Items7 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items7(global::OpenRouter.MessagesMessageParamContentOneOf1Items7? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items8 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items8?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items8;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items8? value)
        {
            MessagesMessageParamContentOneOf1Items8 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items8(global::OpenRouter.MessagesMessageParamContentOneOf1Items8? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicSearchResultBlockParam value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.AnthropicSearchResultBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicSearchResultBlockParam?(MessagesMessageParamContentOneOf1Items @this) => @this.AnthropicSearchResultBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.AnthropicSearchResultBlockParam? value)
        {
            AnthropicSearchResultBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromAnthropicSearchResultBlockParam(global::OpenRouter.AnthropicSearchResultBlockParam? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items10 value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1Items10?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1Items10?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1Items10;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1Items10? value)
        {
            MessagesMessageParamContentOneOf1Items10 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesMessageParamContentOneOf1Items10(global::OpenRouter.MessagesMessageParamContentOneOf1Items10? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesAdvisorToolResultBlock value) => new MessagesMessageParamContentOneOf1Items((global::OpenRouter.MessagesAdvisorToolResultBlock?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesAdvisorToolResultBlock?(MessagesMessageParamContentOneOf1Items @this) => @this.MessagesAdvisorToolResultBlock;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(global::OpenRouter.MessagesAdvisorToolResultBlock? value)
        {
            MessagesAdvisorToolResultBlock = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1Items FromMessagesAdvisorToolResultBlock(global::OpenRouter.MessagesAdvisorToolResultBlock? value) => new MessagesMessageParamContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1Items(
            global::OpenRouter.AnthropicTextBlockParam? anthropicTextBlockParam,
            global::OpenRouter.AnthropicImageBlockParam? anthropicImageBlockParam,
            global::OpenRouter.AnthropicDocumentBlockParam? anthropicDocumentBlockParam,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items3? messagesMessageParamContentOneOf1Items3,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items4? messagesMessageParamContentOneOf1Items4,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items5? messagesMessageParamContentOneOf1Items5,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items6? messagesMessageParamContentOneOf1Items6,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items7? messagesMessageParamContentOneOf1Items7,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items8? messagesMessageParamContentOneOf1Items8,
            global::OpenRouter.AnthropicSearchResultBlockParam? anthropicSearchResultBlockParam,
            global::OpenRouter.MessagesMessageParamContentOneOf1Items10? messagesMessageParamContentOneOf1Items10,
            global::OpenRouter.MessagesAdvisorToolResultBlock? messagesAdvisorToolResultBlock
            )
        {
            AnthropicTextBlockParam = anthropicTextBlockParam;
            AnthropicImageBlockParam = anthropicImageBlockParam;
            AnthropicDocumentBlockParam = anthropicDocumentBlockParam;
            MessagesMessageParamContentOneOf1Items3 = messagesMessageParamContentOneOf1Items3;
            MessagesMessageParamContentOneOf1Items4 = messagesMessageParamContentOneOf1Items4;
            MessagesMessageParamContentOneOf1Items5 = messagesMessageParamContentOneOf1Items5;
            MessagesMessageParamContentOneOf1Items6 = messagesMessageParamContentOneOf1Items6;
            MessagesMessageParamContentOneOf1Items7 = messagesMessageParamContentOneOf1Items7;
            MessagesMessageParamContentOneOf1Items8 = messagesMessageParamContentOneOf1Items8;
            AnthropicSearchResultBlockParam = anthropicSearchResultBlockParam;
            MessagesMessageParamContentOneOf1Items10 = messagesMessageParamContentOneOf1Items10;
            MessagesAdvisorToolResultBlock = messagesAdvisorToolResultBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MessagesAdvisorToolResultBlock as object ??
            MessagesMessageParamContentOneOf1Items10 as object ??
            AnthropicSearchResultBlockParam as object ??
            MessagesMessageParamContentOneOf1Items8 as object ??
            MessagesMessageParamContentOneOf1Items7 as object ??
            MessagesMessageParamContentOneOf1Items6 as object ??
            MessagesMessageParamContentOneOf1Items5 as object ??
            MessagesMessageParamContentOneOf1Items4 as object ??
            MessagesMessageParamContentOneOf1Items3 as object ??
            AnthropicDocumentBlockParam as object ??
            AnthropicImageBlockParam as object ??
            AnthropicTextBlockParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicTextBlockParam?.ToString() ??
            AnthropicImageBlockParam?.ToString() ??
            AnthropicDocumentBlockParam?.ToString() ??
            MessagesMessageParamContentOneOf1Items3?.ToString() ??
            MessagesMessageParamContentOneOf1Items4?.ToString() ??
            MessagesMessageParamContentOneOf1Items5?.ToString() ??
            MessagesMessageParamContentOneOf1Items6?.ToString() ??
            MessagesMessageParamContentOneOf1Items7?.ToString() ??
            MessagesMessageParamContentOneOf1Items8?.ToString() ??
            AnthropicSearchResultBlockParam?.ToString() ??
            MessagesMessageParamContentOneOf1Items10?.ToString() ??
            MessagesAdvisorToolResultBlock?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && IsMessagesMessageParamContentOneOf1Items10 && !IsMessagesAdvisorToolResultBlock || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsAnthropicDocumentBlockParam && !IsMessagesMessageParamContentOneOf1Items3 && !IsMessagesMessageParamContentOneOf1Items4 && !IsMessagesMessageParamContentOneOf1Items5 && !IsMessagesMessageParamContentOneOf1Items6 && !IsMessagesMessageParamContentOneOf1Items7 && !IsMessagesMessageParamContentOneOf1Items8 && !IsAnthropicSearchResultBlockParam && !IsMessagesMessageParamContentOneOf1Items10 && IsMessagesAdvisorToolResultBlock;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlockParam, TResult>? anthropicTextBlockParam = null,
            global::System.Func<global::OpenRouter.AnthropicImageBlockParam, TResult>? anthropicImageBlockParam = null,
            global::System.Func<global::OpenRouter.AnthropicDocumentBlockParam, TResult>? anthropicDocumentBlockParam = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items3, TResult>? messagesMessageParamContentOneOf1Items3 = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items4, TResult>? messagesMessageParamContentOneOf1Items4 = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items5, TResult>? messagesMessageParamContentOneOf1Items5 = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items6, TResult>? messagesMessageParamContentOneOf1Items6 = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items7, TResult>? messagesMessageParamContentOneOf1Items7 = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items8, TResult>? messagesMessageParamContentOneOf1Items8 = null,
            global::System.Func<global::OpenRouter.AnthropicSearchResultBlockParam, TResult>? anthropicSearchResultBlockParam = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1Items10, TResult>? messagesMessageParamContentOneOf1Items10 = null,
            global::System.Func<global::OpenRouter.MessagesAdvisorToolResultBlock, TResult>? messagesAdvisorToolResultBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlockParam && anthropicTextBlockParam != null)
            {
                return anthropicTextBlockParam(AnthropicTextBlockParam!);
            }
            else if (IsAnthropicImageBlockParam && anthropicImageBlockParam != null)
            {
                return anthropicImageBlockParam(AnthropicImageBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam && anthropicDocumentBlockParam != null)
            {
                return anthropicDocumentBlockParam(AnthropicDocumentBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items3 && messagesMessageParamContentOneOf1Items3 != null)
            {
                return messagesMessageParamContentOneOf1Items3(MessagesMessageParamContentOneOf1Items3!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items4 && messagesMessageParamContentOneOf1Items4 != null)
            {
                return messagesMessageParamContentOneOf1Items4(MessagesMessageParamContentOneOf1Items4!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items5 && messagesMessageParamContentOneOf1Items5 != null)
            {
                return messagesMessageParamContentOneOf1Items5(MessagesMessageParamContentOneOf1Items5!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items6 && messagesMessageParamContentOneOf1Items6 != null)
            {
                return messagesMessageParamContentOneOf1Items6(MessagesMessageParamContentOneOf1Items6!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items7 && messagesMessageParamContentOneOf1Items7 != null)
            {
                return messagesMessageParamContentOneOf1Items7(MessagesMessageParamContentOneOf1Items7!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items8 && messagesMessageParamContentOneOf1Items8 != null)
            {
                return messagesMessageParamContentOneOf1Items8(MessagesMessageParamContentOneOf1Items8!);
            }
            else if (IsAnthropicSearchResultBlockParam && anthropicSearchResultBlockParam != null)
            {
                return anthropicSearchResultBlockParam(AnthropicSearchResultBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items10 && messagesMessageParamContentOneOf1Items10 != null)
            {
                return messagesMessageParamContentOneOf1Items10(MessagesMessageParamContentOneOf1Items10!);
            }
            else if (IsMessagesAdvisorToolResultBlock && messagesAdvisorToolResultBlock != null)
            {
                return messagesAdvisorToolResultBlock(MessagesAdvisorToolResultBlock!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? anthropicTextBlockParam = null,

            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? anthropicImageBlockParam = null,

            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParam>? anthropicDocumentBlockParam = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items3>? messagesMessageParamContentOneOf1Items3 = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items4>? messagesMessageParamContentOneOf1Items4 = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items5>? messagesMessageParamContentOneOf1Items5 = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items6>? messagesMessageParamContentOneOf1Items6 = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items7>? messagesMessageParamContentOneOf1Items7 = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items8>? messagesMessageParamContentOneOf1Items8 = null,

            global::System.Action<global::OpenRouter.AnthropicSearchResultBlockParam>? anthropicSearchResultBlockParam = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items10>? messagesMessageParamContentOneOf1Items10 = null,

            global::System.Action<global::OpenRouter.MessagesAdvisorToolResultBlock>? messagesAdvisorToolResultBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlockParam)
            {
                anthropicTextBlockParam?.Invoke(AnthropicTextBlockParam!);
            }
            else if (IsAnthropicImageBlockParam)
            {
                anthropicImageBlockParam?.Invoke(AnthropicImageBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam)
            {
                anthropicDocumentBlockParam?.Invoke(AnthropicDocumentBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items3)
            {
                messagesMessageParamContentOneOf1Items3?.Invoke(MessagesMessageParamContentOneOf1Items3!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items4)
            {
                messagesMessageParamContentOneOf1Items4?.Invoke(MessagesMessageParamContentOneOf1Items4!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items5)
            {
                messagesMessageParamContentOneOf1Items5?.Invoke(MessagesMessageParamContentOneOf1Items5!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items6)
            {
                messagesMessageParamContentOneOf1Items6?.Invoke(MessagesMessageParamContentOneOf1Items6!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items7)
            {
                messagesMessageParamContentOneOf1Items7?.Invoke(MessagesMessageParamContentOneOf1Items7!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items8)
            {
                messagesMessageParamContentOneOf1Items8?.Invoke(MessagesMessageParamContentOneOf1Items8!);
            }
            else if (IsAnthropicSearchResultBlockParam)
            {
                anthropicSearchResultBlockParam?.Invoke(AnthropicSearchResultBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items10)
            {
                messagesMessageParamContentOneOf1Items10?.Invoke(MessagesMessageParamContentOneOf1Items10!);
            }
            else if (IsMessagesAdvisorToolResultBlock)
            {
                messagesAdvisorToolResultBlock?.Invoke(MessagesAdvisorToolResultBlock!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? anthropicTextBlockParam = null,
            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? anthropicImageBlockParam = null,
            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParam>? anthropicDocumentBlockParam = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items3>? messagesMessageParamContentOneOf1Items3 = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items4>? messagesMessageParamContentOneOf1Items4 = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items5>? messagesMessageParamContentOneOf1Items5 = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items6>? messagesMessageParamContentOneOf1Items6 = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items7>? messagesMessageParamContentOneOf1Items7 = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items8>? messagesMessageParamContentOneOf1Items8 = null,
            global::System.Action<global::OpenRouter.AnthropicSearchResultBlockParam>? anthropicSearchResultBlockParam = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1Items10>? messagesMessageParamContentOneOf1Items10 = null,
            global::System.Action<global::OpenRouter.MessagesAdvisorToolResultBlock>? messagesAdvisorToolResultBlock = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAnthropicTextBlockParam)
            {
                anthropicTextBlockParam?.Invoke(AnthropicTextBlockParam!);
            }
            else if (IsAnthropicImageBlockParam)
            {
                anthropicImageBlockParam?.Invoke(AnthropicImageBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam)
            {
                anthropicDocumentBlockParam?.Invoke(AnthropicDocumentBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items3)
            {
                messagesMessageParamContentOneOf1Items3?.Invoke(MessagesMessageParamContentOneOf1Items3!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items4)
            {
                messagesMessageParamContentOneOf1Items4?.Invoke(MessagesMessageParamContentOneOf1Items4!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items5)
            {
                messagesMessageParamContentOneOf1Items5?.Invoke(MessagesMessageParamContentOneOf1Items5!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items6)
            {
                messagesMessageParamContentOneOf1Items6?.Invoke(MessagesMessageParamContentOneOf1Items6!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items7)
            {
                messagesMessageParamContentOneOf1Items7?.Invoke(MessagesMessageParamContentOneOf1Items7!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items8)
            {
                messagesMessageParamContentOneOf1Items8?.Invoke(MessagesMessageParamContentOneOf1Items8!);
            }
            else if (IsAnthropicSearchResultBlockParam)
            {
                anthropicSearchResultBlockParam?.Invoke(AnthropicSearchResultBlockParam!);
            }
            else if (IsMessagesMessageParamContentOneOf1Items10)
            {
                messagesMessageParamContentOneOf1Items10?.Invoke(MessagesMessageParamContentOneOf1Items10!);
            }
            else if (IsMessagesAdvisorToolResultBlock)
            {
                messagesAdvisorToolResultBlock?.Invoke(MessagesAdvisorToolResultBlock!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                AnthropicTextBlockParam,
                typeof(global::OpenRouter.AnthropicTextBlockParam),
                AnthropicImageBlockParam,
                typeof(global::OpenRouter.AnthropicImageBlockParam),
                AnthropicDocumentBlockParam,
                typeof(global::OpenRouter.AnthropicDocumentBlockParam),
                MessagesMessageParamContentOneOf1Items3,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items3),
                MessagesMessageParamContentOneOf1Items4,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items4),
                MessagesMessageParamContentOneOf1Items5,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items5),
                MessagesMessageParamContentOneOf1Items6,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items6),
                MessagesMessageParamContentOneOf1Items7,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items7),
                MessagesMessageParamContentOneOf1Items8,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items8),
                AnthropicSearchResultBlockParam,
                typeof(global::OpenRouter.AnthropicSearchResultBlockParam),
                MessagesMessageParamContentOneOf1Items10,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1Items10),
                MessagesAdvisorToolResultBlock,
                typeof(global::OpenRouter.MessagesAdvisorToolResultBlock),
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
        public bool Equals(MessagesMessageParamContentOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParam?>.Default.Equals(AnthropicTextBlockParam, other.AnthropicTextBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParam?>.Default.Equals(AnthropicImageBlockParam, other.AnthropicImageBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDocumentBlockParam?>.Default.Equals(AnthropicDocumentBlockParam, other.AnthropicDocumentBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items3?>.Default.Equals(MessagesMessageParamContentOneOf1Items3, other.MessagesMessageParamContentOneOf1Items3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items4?>.Default.Equals(MessagesMessageParamContentOneOf1Items4, other.MessagesMessageParamContentOneOf1Items4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items5?>.Default.Equals(MessagesMessageParamContentOneOf1Items5, other.MessagesMessageParamContentOneOf1Items5) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items6?>.Default.Equals(MessagesMessageParamContentOneOf1Items6, other.MessagesMessageParamContentOneOf1Items6) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items7?>.Default.Equals(MessagesMessageParamContentOneOf1Items7, other.MessagesMessageParamContentOneOf1Items7) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items8?>.Default.Equals(MessagesMessageParamContentOneOf1Items8, other.MessagesMessageParamContentOneOf1Items8) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicSearchResultBlockParam?>.Default.Equals(AnthropicSearchResultBlockParam, other.AnthropicSearchResultBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1Items10?>.Default.Equals(MessagesMessageParamContentOneOf1Items10, other.MessagesMessageParamContentOneOf1Items10) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesAdvisorToolResultBlock?>.Default.Equals(MessagesAdvisorToolResultBlock, other.MessagesAdvisorToolResultBlock) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1Items obj1, MessagesMessageParamContentOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1Items obj1, MessagesMessageParamContentOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1Items o && Equals(o);
        }
    }
}
