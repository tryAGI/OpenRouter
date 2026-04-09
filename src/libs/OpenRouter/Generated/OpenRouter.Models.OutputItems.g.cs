#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// An output item from the response
    /// </summary>
    public readonly partial struct OutputItems : global::System.IEquatable<OutputItems>
    {
        /// <summary>
        /// file_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant1? FileSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant1? FileSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FileSearchCall))]
#endif
        public bool IsFileSearchCall => FileSearchCall != null;

        /// <summary>
        /// function_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant2? FunctionCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant2? FunctionCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionCall))]
#endif
        public bool IsFunctionCall => FunctionCall != null;

        /// <summary>
        /// image_generation_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant3? ImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant3? ImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageGenerationCall))]
#endif
        public bool IsImageGenerationCall => ImageGenerationCall != null;

        /// <summary>
        /// message variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant4? Message { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant4? Message { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Message))]
#endif
        public bool IsMessage => Message != null;

        /// <summary>
        /// openrouter:datetime variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant5? OpenrouterDatetime { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant5? OpenrouterDatetime { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterDatetime))]
#endif
        public bool IsOpenrouterDatetime => OpenrouterDatetime != null;

        /// <summary>
        /// openrouter:web_search variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant6? OpenrouterWebSearch { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant6? OpenrouterWebSearch { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenrouterWebSearch))]
#endif
        public bool IsOpenrouterWebSearch => OpenrouterWebSearch != null;

        /// <summary>
        /// reasoning variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant7? Reasoning { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant7? Reasoning { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Reasoning))]
#endif
        public bool IsReasoning => Reasoning != null;

        /// <summary>
        /// web_search_call variant
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemsVariant8? WebSearchCall { get; init; }
#else
        public global::OpenRouter.OutputItemsVariant8? WebSearchCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(WebSearchCall))]
#endif
        public bool IsWebSearchCall => WebSearchCall != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant1 value) => new OutputItems((global::OpenRouter.OutputItemsVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant1?(OutputItems @this) => @this.FileSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant1? value)
        {
            FileSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant2 value) => new OutputItems((global::OpenRouter.OutputItemsVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant2?(OutputItems @this) => @this.FunctionCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant2? value)
        {
            FunctionCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant3 value) => new OutputItems((global::OpenRouter.OutputItemsVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant3?(OutputItems @this) => @this.ImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant3? value)
        {
            ImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant4 value) => new OutputItems((global::OpenRouter.OutputItemsVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant4?(OutputItems @this) => @this.Message;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant4? value)
        {
            Message = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant5 value) => new OutputItems((global::OpenRouter.OutputItemsVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant5?(OutputItems @this) => @this.OpenrouterDatetime;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant5? value)
        {
            OpenrouterDatetime = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant6 value) => new OutputItems((global::OpenRouter.OutputItemsVariant6?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant6?(OutputItems @this) => @this.OpenrouterWebSearch;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant6? value)
        {
            OpenrouterWebSearch = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant7 value) => new OutputItems((global::OpenRouter.OutputItemsVariant7?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant7?(OutputItems @this) => @this.Reasoning;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant7? value)
        {
            Reasoning = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OutputItems(global::OpenRouter.OutputItemsVariant8 value) => new OutputItems((global::OpenRouter.OutputItemsVariant8?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemsVariant8?(OutputItems @this) => @this.WebSearchCall;

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(global::OpenRouter.OutputItemsVariant8? value)
        {
            WebSearchCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OutputItems(
            global::OpenRouter.OutputItemsVariant1? fileSearchCall,
            global::OpenRouter.OutputItemsVariant2? functionCall,
            global::OpenRouter.OutputItemsVariant3? imageGenerationCall,
            global::OpenRouter.OutputItemsVariant4? message,
            global::OpenRouter.OutputItemsVariant5? openrouterDatetime,
            global::OpenRouter.OutputItemsVariant6? openrouterWebSearch,
            global::OpenRouter.OutputItemsVariant7? reasoning,
            global::OpenRouter.OutputItemsVariant8? webSearchCall
            )
        {
            FileSearchCall = fileSearchCall;
            FunctionCall = functionCall;
            ImageGenerationCall = imageGenerationCall;
            Message = message;
            OpenrouterDatetime = openrouterDatetime;
            OpenrouterWebSearch = openrouterWebSearch;
            Reasoning = reasoning;
            WebSearchCall = webSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            WebSearchCall as object ??
            Reasoning as object ??
            OpenrouterWebSearch as object ??
            OpenrouterDatetime as object ??
            Message as object ??
            ImageGenerationCall as object ??
            FunctionCall as object ??
            FileSearchCall as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            FileSearchCall?.ToString() ??
            FunctionCall?.ToString() ??
            ImageGenerationCall?.ToString() ??
            Message?.ToString() ??
            OpenrouterDatetime?.ToString() ??
            OpenrouterWebSearch?.ToString() ??
            Reasoning?.ToString() ??
            WebSearchCall?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && IsOpenrouterWebSearch && !IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && IsReasoning && !IsWebSearchCall || !IsFileSearchCall && !IsFunctionCall && !IsImageGenerationCall && !IsMessage && !IsOpenrouterDatetime && !IsOpenrouterWebSearch && !IsReasoning && IsWebSearchCall;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.OutputItemsVariant1?, TResult>? fileSearchCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant2?, TResult>? functionCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant3?, TResult>? imageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant4?, TResult>? message = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant5?, TResult>? openrouterDatetime = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant6?, TResult>? openrouterWebSearch = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant7?, TResult>? reasoning = null,
            global::System.Func<global::OpenRouter.OutputItemsVariant8?, TResult>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchCall && fileSearchCall != null)
            {
                return fileSearchCall(FileSearchCall!);
            }
            else if (IsFunctionCall && functionCall != null)
            {
                return functionCall(FunctionCall!);
            }
            else if (IsImageGenerationCall && imageGenerationCall != null)
            {
                return imageGenerationCall(ImageGenerationCall!);
            }
            else if (IsMessage && message != null)
            {
                return message(Message!);
            }
            else if (IsOpenrouterDatetime && openrouterDatetime != null)
            {
                return openrouterDatetime(OpenrouterDatetime!);
            }
            else if (IsOpenrouterWebSearch && openrouterWebSearch != null)
            {
                return openrouterWebSearch(OpenrouterWebSearch!);
            }
            else if (IsReasoning && reasoning != null)
            {
                return reasoning(Reasoning!);
            }
            else if (IsWebSearchCall && webSearchCall != null)
            {
                return webSearchCall(WebSearchCall!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.OutputItemsVariant1?>? fileSearchCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant2?>? functionCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant3?>? imageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant4?>? message = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant5?>? openrouterDatetime = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant6?>? openrouterWebSearch = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant7?>? reasoning = null,
            global::System.Action<global::OpenRouter.OutputItemsVariant8?>? webSearchCall = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsFileSearchCall)
            {
                fileSearchCall?.Invoke(FileSearchCall!);
            }
            else if (IsFunctionCall)
            {
                functionCall?.Invoke(FunctionCall!);
            }
            else if (IsImageGenerationCall)
            {
                imageGenerationCall?.Invoke(ImageGenerationCall!);
            }
            else if (IsMessage)
            {
                message?.Invoke(Message!);
            }
            else if (IsOpenrouterDatetime)
            {
                openrouterDatetime?.Invoke(OpenrouterDatetime!);
            }
            else if (IsOpenrouterWebSearch)
            {
                openrouterWebSearch?.Invoke(OpenrouterWebSearch!);
            }
            else if (IsReasoning)
            {
                reasoning?.Invoke(Reasoning!);
            }
            else if (IsWebSearchCall)
            {
                webSearchCall?.Invoke(WebSearchCall!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                FileSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant1),
                FunctionCall,
                typeof(global::OpenRouter.OutputItemsVariant2),
                ImageGenerationCall,
                typeof(global::OpenRouter.OutputItemsVariant3),
                Message,
                typeof(global::OpenRouter.OutputItemsVariant4),
                OpenrouterDatetime,
                typeof(global::OpenRouter.OutputItemsVariant5),
                OpenrouterWebSearch,
                typeof(global::OpenRouter.OutputItemsVariant6),
                Reasoning,
                typeof(global::OpenRouter.OutputItemsVariant7),
                WebSearchCall,
                typeof(global::OpenRouter.OutputItemsVariant8),
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
        public bool Equals(OutputItems other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant1?>.Default.Equals(FileSearchCall, other.FileSearchCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant2?>.Default.Equals(FunctionCall, other.FunctionCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant3?>.Default.Equals(ImageGenerationCall, other.ImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant4?>.Default.Equals(Message, other.Message) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant5?>.Default.Equals(OpenrouterDatetime, other.OpenrouterDatetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant6?>.Default.Equals(OpenrouterWebSearch, other.OpenrouterWebSearch) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant7?>.Default.Equals(Reasoning, other.Reasoning) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemsVariant8?>.Default.Equals(WebSearchCall, other.WebSearchCall) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OutputItems obj1, OutputItems obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OutputItems>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OutputItems obj1, OutputItems obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OutputItems o && Equals(o);
        }
    }
}
