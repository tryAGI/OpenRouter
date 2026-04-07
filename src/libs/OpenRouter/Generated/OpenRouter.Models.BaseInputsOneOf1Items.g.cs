#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct BaseInputsOneOf1Items : global::System.IEquatable<BaseInputsOneOf1Items>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1Items0? BaseInputsOneOf1Items0 { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1Items0? BaseInputsOneOf1Items0 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1Items0))]
#endif
        public bool IsBaseInputsOneOf1Items0 => BaseInputsOneOf1Items0 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponseInputMessageItem? OpenAIResponseInputMessageItem { get; init; }
#else
        public global::OpenRouter.OpenAIResponseInputMessageItem? OpenAIResponseInputMessageItem { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponseInputMessageItem))]
#endif
        public bool IsOpenAIResponseInputMessageItem => OpenAIResponseInputMessageItem != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? OpenAIResponseFunctionToolCallOutput { get; init; }
#else
        public global::OpenRouter.OpenAIResponseFunctionToolCallOutput? OpenAIResponseFunctionToolCallOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponseFunctionToolCallOutput))]
#endif
        public bool IsOpenAIResponseFunctionToolCallOutput => OpenAIResponseFunctionToolCallOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OpenAIResponseFunctionToolCall? OpenAIResponseFunctionToolCall { get; init; }
#else
        public global::OpenRouter.OpenAIResponseFunctionToolCall? OpenAIResponseFunctionToolCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OpenAIResponseFunctionToolCall))]
#endif
        public bool IsOpenAIResponseFunctionToolCall => OpenAIResponseFunctionToolCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; init; }
#else
        public global::OpenRouter.OutputItemImageGenerationCall? OutputItemImageGenerationCall { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputItemImageGenerationCall))]
#endif
        public bool IsOutputItemImageGenerationCall => OutputItemImageGenerationCall != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.OutputMessage? OutputMessage { get; init; }
#else
        public global::OpenRouter.OutputMessage? OutputMessage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(OutputMessage))]
#endif
        public bool IsOutputMessage => OutputMessage != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items0 value) => new BaseInputsOneOf1Items((global::OpenRouter.BaseInputsOneOf1Items0?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1Items0?(BaseInputsOneOf1Items @this) => @this.BaseInputsOneOf1Items0;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items0? value)
        {
            BaseInputsOneOf1Items0 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseInputMessageItem value) => new BaseInputsOneOf1Items((global::OpenRouter.OpenAIResponseInputMessageItem?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponseInputMessageItem?(BaseInputsOneOf1Items @this) => @this.OpenAIResponseInputMessageItem;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseInputMessageItem? value)
        {
            OpenAIResponseInputMessageItem = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseFunctionToolCallOutput value) => new BaseInputsOneOf1Items((global::OpenRouter.OpenAIResponseFunctionToolCallOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponseFunctionToolCallOutput?(BaseInputsOneOf1Items @this) => @this.OpenAIResponseFunctionToolCallOutput;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseFunctionToolCallOutput? value)
        {
            OpenAIResponseFunctionToolCallOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseFunctionToolCall value) => new BaseInputsOneOf1Items((global::OpenRouter.OpenAIResponseFunctionToolCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OpenAIResponseFunctionToolCall?(BaseInputsOneOf1Items @this) => @this.OpenAIResponseFunctionToolCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.OpenAIResponseFunctionToolCall? value)
        {
            OpenAIResponseFunctionToolCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.OutputItemImageGenerationCall value) => new BaseInputsOneOf1Items((global::OpenRouter.OutputItemImageGenerationCall?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputItemImageGenerationCall?(BaseInputsOneOf1Items @this) => @this.OutputItemImageGenerationCall;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.OutputItemImageGenerationCall? value)
        {
            OutputItemImageGenerationCall = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.OutputMessage value) => new BaseInputsOneOf1Items((global::OpenRouter.OutputMessage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.OutputMessage?(BaseInputsOneOf1Items @this) => @this.OutputMessage;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.OutputMessage? value)
        {
            OutputMessage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(
            global::OpenRouter.BaseInputsOneOf1Items0? baseInputsOneOf1Items0,
            global::OpenRouter.OpenAIResponseInputMessageItem? openAIResponseInputMessageItem,
            global::OpenRouter.OpenAIResponseFunctionToolCallOutput? openAIResponseFunctionToolCallOutput,
            global::OpenRouter.OpenAIResponseFunctionToolCall? openAIResponseFunctionToolCall,
            global::OpenRouter.OutputItemImageGenerationCall? outputItemImageGenerationCall,
            global::OpenRouter.OutputMessage? outputMessage
            )
        {
            BaseInputsOneOf1Items0 = baseInputsOneOf1Items0;
            OpenAIResponseInputMessageItem = openAIResponseInputMessageItem;
            OpenAIResponseFunctionToolCallOutput = openAIResponseFunctionToolCallOutput;
            OpenAIResponseFunctionToolCall = openAIResponseFunctionToolCall;
            OutputItemImageGenerationCall = outputItemImageGenerationCall;
            OutputMessage = outputMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessage as object ??
            OutputItemImageGenerationCall as object ??
            OpenAIResponseFunctionToolCall as object ??
            OpenAIResponseFunctionToolCallOutput as object ??
            OpenAIResponseInputMessageItem as object ??
            BaseInputsOneOf1Items0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1Items0?.ToString() ??
            OpenAIResponseInputMessageItem?.ToString() ??
            OpenAIResponseFunctionToolCallOutput?.ToString() ??
            OpenAIResponseFunctionToolCall?.ToString() ??
            OutputItemImageGenerationCall?.ToString() ??
            OutputMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1Items0 && !IsOpenAIResponseInputMessageItem && !IsOpenAIResponseFunctionToolCallOutput && !IsOpenAIResponseFunctionToolCall && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && IsOpenAIResponseInputMessageItem && !IsOpenAIResponseFunctionToolCallOutput && !IsOpenAIResponseFunctionToolCall && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsOpenAIResponseInputMessageItem && IsOpenAIResponseFunctionToolCallOutput && !IsOpenAIResponseFunctionToolCall && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsOpenAIResponseInputMessageItem && !IsOpenAIResponseFunctionToolCallOutput && IsOpenAIResponseFunctionToolCall && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsOpenAIResponseInputMessageItem && !IsOpenAIResponseFunctionToolCallOutput && !IsOpenAIResponseFunctionToolCall && IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsOpenAIResponseInputMessageItem && !IsOpenAIResponseFunctionToolCallOutput && !IsOpenAIResponseFunctionToolCall && !IsOutputItemImageGenerationCall && IsOutputMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseInputsOneOf1Items0?, TResult>? baseInputsOneOf1Items0 = null,
            global::System.Func<global::OpenRouter.OpenAIResponseInputMessageItem?, TResult>? openAIResponseInputMessageItem = null,
            global::System.Func<global::OpenRouter.OpenAIResponseFunctionToolCallOutput?, TResult>? openAIResponseFunctionToolCallOutput = null,
            global::System.Func<global::OpenRouter.OpenAIResponseFunctionToolCall?, TResult>? openAIResponseFunctionToolCall = null,
            global::System.Func<global::OpenRouter.OutputItemImageGenerationCall?, TResult>? outputItemImageGenerationCall = null,
            global::System.Func<global::OpenRouter.OutputMessage?, TResult>? outputMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1Items0 && baseInputsOneOf1Items0 != null)
            {
                return baseInputsOneOf1Items0(BaseInputsOneOf1Items0!);
            }
            else if (IsOpenAIResponseInputMessageItem && openAIResponseInputMessageItem != null)
            {
                return openAIResponseInputMessageItem(OpenAIResponseInputMessageItem!);
            }
            else if (IsOpenAIResponseFunctionToolCallOutput && openAIResponseFunctionToolCallOutput != null)
            {
                return openAIResponseFunctionToolCallOutput(OpenAIResponseFunctionToolCallOutput!);
            }
            else if (IsOpenAIResponseFunctionToolCall && openAIResponseFunctionToolCall != null)
            {
                return openAIResponseFunctionToolCall(OpenAIResponseFunctionToolCall!);
            }
            else if (IsOutputItemImageGenerationCall && outputItemImageGenerationCall != null)
            {
                return outputItemImageGenerationCall(OutputItemImageGenerationCall!);
            }
            else if (IsOutputMessage && outputMessage != null)
            {
                return outputMessage(OutputMessage!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.BaseInputsOneOf1Items0?>? baseInputsOneOf1Items0 = null,
            global::System.Action<global::OpenRouter.OpenAIResponseInputMessageItem?>? openAIResponseInputMessageItem = null,
            global::System.Action<global::OpenRouter.OpenAIResponseFunctionToolCallOutput?>? openAIResponseFunctionToolCallOutput = null,
            global::System.Action<global::OpenRouter.OpenAIResponseFunctionToolCall?>? openAIResponseFunctionToolCall = null,
            global::System.Action<global::OpenRouter.OutputItemImageGenerationCall?>? outputItemImageGenerationCall = null,
            global::System.Action<global::OpenRouter.OutputMessage?>? outputMessage = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsBaseInputsOneOf1Items0)
            {
                baseInputsOneOf1Items0?.Invoke(BaseInputsOneOf1Items0!);
            }
            else if (IsOpenAIResponseInputMessageItem)
            {
                openAIResponseInputMessageItem?.Invoke(OpenAIResponseInputMessageItem!);
            }
            else if (IsOpenAIResponseFunctionToolCallOutput)
            {
                openAIResponseFunctionToolCallOutput?.Invoke(OpenAIResponseFunctionToolCallOutput!);
            }
            else if (IsOpenAIResponseFunctionToolCall)
            {
                openAIResponseFunctionToolCall?.Invoke(OpenAIResponseFunctionToolCall!);
            }
            else if (IsOutputItemImageGenerationCall)
            {
                outputItemImageGenerationCall?.Invoke(OutputItemImageGenerationCall!);
            }
            else if (IsOutputMessage)
            {
                outputMessage?.Invoke(OutputMessage!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BaseInputsOneOf1Items0,
                typeof(global::OpenRouter.BaseInputsOneOf1Items0),
                OpenAIResponseInputMessageItem,
                typeof(global::OpenRouter.OpenAIResponseInputMessageItem),
                OpenAIResponseFunctionToolCallOutput,
                typeof(global::OpenRouter.OpenAIResponseFunctionToolCallOutput),
                OpenAIResponseFunctionToolCall,
                typeof(global::OpenRouter.OpenAIResponseFunctionToolCall),
                OutputItemImageGenerationCall,
                typeof(global::OpenRouter.OutputItemImageGenerationCall),
                OutputMessage,
                typeof(global::OpenRouter.OutputMessage),
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
        public bool Equals(BaseInputsOneOf1Items other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1Items0?>.Default.Equals(BaseInputsOneOf1Items0, other.BaseInputsOneOf1Items0) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponseInputMessageItem?>.Default.Equals(OpenAIResponseInputMessageItem, other.OpenAIResponseInputMessageItem) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponseFunctionToolCallOutput?>.Default.Equals(OpenAIResponseFunctionToolCallOutput, other.OpenAIResponseFunctionToolCallOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OpenAIResponseFunctionToolCall?>.Default.Equals(OpenAIResponseFunctionToolCall, other.OpenAIResponseFunctionToolCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputItemImageGenerationCall?>.Default.Equals(OutputItemImageGenerationCall, other.OutputItemImageGenerationCall) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.OutputMessage?>.Default.Equals(OutputMessage, other.OutputMessage) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(BaseInputsOneOf1Items obj1, BaseInputsOneOf1Items obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BaseInputsOneOf1Items>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(BaseInputsOneOf1Items obj1, BaseInputsOneOf1Items obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BaseInputsOneOf1Items o && Equals(o);
        }
    }
}
