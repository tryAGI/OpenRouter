#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items : global::System.IEquatable<MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>
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
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 { get; init; }
#else
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2))]
#endif
        public bool IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 => MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? value)
        {
            value = MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2;
            return IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 PickMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2() => IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2
            ? MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2' but the value was {ToString()}.");

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
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items((global::OpenRouter.AnthropicTextBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicTextBlockParam?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items @this) => @this.AnthropicTextBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicTextBlockParam? value)
        {
            AnthropicTextBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items FromAnthropicTextBlockParam(global::OpenRouter.AnthropicTextBlockParam? value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items((global::OpenRouter.AnthropicImageBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicImageBlockParam?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items @this) => @this.AnthropicImageBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicImageBlockParam? value)
        {
            AnthropicImageBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items FromAnthropicImageBlockParam(global::OpenRouter.AnthropicImageBlockParam? value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items((global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items @this) => @this.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? value)
        {
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items FromMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicSearchResultBlockParam value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items((global::OpenRouter.AnthropicSearchResultBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicSearchResultBlockParam?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items @this) => @this.AnthropicSearchResultBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicSearchResultBlockParam? value)
        {
            AnthropicSearchResultBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items FromAnthropicSearchResultBlockParam(global::OpenRouter.AnthropicSearchResultBlockParam? value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParam value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items((global::OpenRouter.AnthropicDocumentBlockParam?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicDocumentBlockParam?(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items @this) => @this.AnthropicDocumentBlockParam;

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(global::OpenRouter.AnthropicDocumentBlockParam? value)
        {
            AnthropicDocumentBlockParam = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items FromAnthropicDocumentBlockParam(global::OpenRouter.AnthropicDocumentBlockParam? value) => new MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(value);

        /// <summary>
        /// 
        /// </summary>
        public MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items(
            global::OpenRouter.AnthropicTextBlockParam? anthropicTextBlockParam,
            global::OpenRouter.AnthropicImageBlockParam? anthropicImageBlockParam,
            global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2,
            global::OpenRouter.AnthropicSearchResultBlockParam? anthropicSearchResultBlockParam,
            global::OpenRouter.AnthropicDocumentBlockParam? anthropicDocumentBlockParam
            )
        {
            AnthropicTextBlockParam = anthropicTextBlockParam;
            AnthropicImageBlockParam = anthropicImageBlockParam;
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2;
            AnthropicSearchResultBlockParam = anthropicSearchResultBlockParam;
            AnthropicDocumentBlockParam = anthropicDocumentBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicDocumentBlockParam as object ??
            AnthropicSearchResultBlockParam as object ??
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 as object ??
            AnthropicImageBlockParam as object ??
            AnthropicTextBlockParam as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            AnthropicTextBlockParam?.ToString() ??
            AnthropicImageBlockParam?.ToString() ??
            MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?.ToString() ??
            AnthropicSearchResultBlockParam?.ToString() ??
            AnthropicDocumentBlockParam?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && !IsAnthropicSearchResultBlockParam && !IsAnthropicDocumentBlockParam || !IsAnthropicTextBlockParam && IsAnthropicImageBlockParam && !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && !IsAnthropicSearchResultBlockParam && !IsAnthropicDocumentBlockParam || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && !IsAnthropicSearchResultBlockParam && !IsAnthropicDocumentBlockParam || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && IsAnthropicSearchResultBlockParam && !IsAnthropicDocumentBlockParam || !IsAnthropicTextBlockParam && !IsAnthropicImageBlockParam && !IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && !IsAnthropicSearchResultBlockParam && IsAnthropicDocumentBlockParam;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.AnthropicTextBlockParam, TResult>? anthropicTextBlockParam = null,
            global::System.Func<global::OpenRouter.AnthropicImageBlockParam, TResult>? anthropicImageBlockParam = null,
            global::System.Func<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2, TResult>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = null,
            global::System.Func<global::OpenRouter.AnthropicSearchResultBlockParam, TResult>? anthropicSearchResultBlockParam = null,
            global::System.Func<global::OpenRouter.AnthropicDocumentBlockParam, TResult>? anthropicDocumentBlockParam = null,
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
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 && messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 != null)
            {
                return messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2!);
            }
            else if (IsAnthropicSearchResultBlockParam && anthropicSearchResultBlockParam != null)
            {
                return anthropicSearchResultBlockParam(AnthropicSearchResultBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam && anthropicDocumentBlockParam != null)
            {
                return anthropicDocumentBlockParam(AnthropicDocumentBlockParam!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? anthropicTextBlockParam = null,

            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? anthropicImageBlockParam = null,

            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = null,

            global::System.Action<global::OpenRouter.AnthropicSearchResultBlockParam>? anthropicSearchResultBlockParam = null,

            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParam>? anthropicDocumentBlockParam = null,
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
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2)
            {
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2!);
            }
            else if (IsAnthropicSearchResultBlockParam)
            {
                anthropicSearchResultBlockParam?.Invoke(AnthropicSearchResultBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam)
            {
                anthropicDocumentBlockParam?.Invoke(AnthropicDocumentBlockParam!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.AnthropicTextBlockParam>? anthropicTextBlockParam = null,
            global::System.Action<global::OpenRouter.AnthropicImageBlockParam>? anthropicImageBlockParam = null,
            global::System.Action<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2>? messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2 = null,
            global::System.Action<global::OpenRouter.AnthropicSearchResultBlockParam>? anthropicSearchResultBlockParam = null,
            global::System.Action<global::OpenRouter.AnthropicDocumentBlockParam>? anthropicDocumentBlockParam = null,
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
            else if (IsMessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2)
            {
                messagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?.Invoke(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2!);
            }
            else if (IsAnthropicSearchResultBlockParam)
            {
                anthropicSearchResultBlockParam?.Invoke(AnthropicSearchResultBlockParam!);
            }
            else if (IsAnthropicDocumentBlockParam)
            {
                anthropicDocumentBlockParam?.Invoke(AnthropicDocumentBlockParam!);
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
                MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2,
                typeof(global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2),
                AnthropicSearchResultBlockParam,
                typeof(global::OpenRouter.AnthropicSearchResultBlockParam),
                AnthropicDocumentBlockParam,
                typeof(global::OpenRouter.AnthropicDocumentBlockParam),
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
        public bool Equals(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicTextBlockParam?>.Default.Equals(AnthropicTextBlockParam, other.AnthropicTextBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicImageBlockParam?>.Default.Equals(AnthropicImageBlockParam, other.AnthropicImageBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2?>.Default.Equals(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2, other.MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicSearchResultBlockParam?>.Default.Equals(AnthropicSearchResultBlockParam, other.AnthropicSearchResultBlockParam) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicDocumentBlockParam?>.Default.Equals(AnthropicDocumentBlockParam, other.AnthropicDocumentBlockParam) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items obj1, MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items obj1, MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesMessageParamContentOneOf1ItemsOneOf4ContentOneOf1Items o && Equals(o);
        }
    }
}
