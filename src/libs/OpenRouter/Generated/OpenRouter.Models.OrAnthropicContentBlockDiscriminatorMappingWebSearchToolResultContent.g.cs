#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent : global::System.IEquatable<OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0))]
#endif
        public bool IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 => OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? value)
        {
            value = OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0;
            return IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult> PickOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0() => IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0
            ? OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0!
            : throw new global::System.InvalidOperationException($"Expected union variant 'OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.AnthropicWebSearchToolResultError? AnthropicWebSearchToolResultError { get; init; }
#else
        public global::OpenRouter.AnthropicWebSearchToolResultError? AnthropicWebSearchToolResultError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AnthropicWebSearchToolResultError))]
#endif
        public bool IsAnthropicWebSearchToolResultError => AnthropicWebSearchToolResultError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAnthropicWebSearchToolResultError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.AnthropicWebSearchToolResultError? value)
        {
            value = AnthropicWebSearchToolResultError;
            return IsAnthropicWebSearchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.AnthropicWebSearchToolResultError PickAnthropicWebSearchToolResultError() => IsAnthropicWebSearchToolResultError
            ? AnthropicWebSearchToolResultError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AnthropicWebSearchToolResultError' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent(global::OpenRouter.AnthropicWebSearchToolResultError value) => new OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent((global::OpenRouter.AnthropicWebSearchToolResultError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.AnthropicWebSearchToolResultError?(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent @this) => @this.AnthropicWebSearchToolResultError;

        /// <summary>
        /// 
        /// </summary>
        public OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent(global::OpenRouter.AnthropicWebSearchToolResultError? value)
        {
            AnthropicWebSearchToolResultError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent FromAnthropicWebSearchToolResultError(global::OpenRouter.AnthropicWebSearchToolResultError? value) => new OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent(value);

        /// <summary>
        /// 
        /// </summary>
        public OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent(
            global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>? orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0,
            global::OpenRouter.AnthropicWebSearchToolResultError? anthropicWebSearchToolResultError
            )
        {
            OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 = orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0;
            AnthropicWebSearchToolResultError = anthropicWebSearchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AnthropicWebSearchToolResultError as object ??
            OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0?.ToString() ??
            AnthropicWebSearchToolResultError?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 && !IsAnthropicWebSearchToolResultError || !IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 && IsAnthropicWebSearchToolResultError;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>, TResult>? orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 = null,
            global::System.Func<global::OpenRouter.AnthropicWebSearchToolResultError, TResult>? anthropicWebSearchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 && orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 != null)
            {
                return orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0!);
            }
            else if (IsAnthropicWebSearchToolResultError && anthropicWebSearchToolResultError != null)
            {
                return anthropicWebSearchToolResultError(AnthropicWebSearchToolResultError!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>>? orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 = null,

            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResultError>? anthropicWebSearchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0)
            {
                orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0?.Invoke(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0!);
            }
            else if (IsAnthropicWebSearchToolResultError)
            {
                anthropicWebSearchToolResultError?.Invoke(AnthropicWebSearchToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>>? orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0 = null,
            global::System.Action<global::OpenRouter.AnthropicWebSearchToolResultError>? anthropicWebSearchToolResultError = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsOrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0)
            {
                orAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0?.Invoke(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0!);
            }
            else if (IsAnthropicWebSearchToolResultError)
            {
                anthropicWebSearchToolResultError?.Invoke(AnthropicWebSearchToolResultError!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>),
                AnthropicWebSearchToolResultError,
                typeof(global::OpenRouter.AnthropicWebSearchToolResultError),
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
        public bool Equals(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.AnthropicWebSearchResult>?>.Default.Equals(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0, other.OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.AnthropicWebSearchToolResultError?>.Default.Equals(AnthropicWebSearchToolResultError, other.AnthropicWebSearchToolResultError) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent obj1, OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent obj1, OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OrAnthropicContentBlockDiscriminatorMappingWebSearchToolResultContent o && Equals(o);
        }
    }
}
