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
        public global::OpenRouter.BaseInputsOneOf1Items1? BaseInputsOneOf1Items1 { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1Items1? BaseInputsOneOf1Items1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1Items1))]
#endif
        public bool IsBaseInputsOneOf1Items1 => BaseInputsOneOf1Items1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1Items2? BaseInputsOneOf1Items2 { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1Items2? BaseInputsOneOf1Items2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1Items2))]
#endif
        public bool IsBaseInputsOneOf1Items2 => BaseInputsOneOf1Items2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.BaseInputsOneOf1Items3? BaseInputsOneOf1Items3 { get; init; }
#else
        public global::OpenRouter.BaseInputsOneOf1Items3? BaseInputsOneOf1Items3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BaseInputsOneOf1Items3))]
#endif
        public bool IsBaseInputsOneOf1Items3 => BaseInputsOneOf1Items3 != null;

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
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items1 value) => new BaseInputsOneOf1Items((global::OpenRouter.BaseInputsOneOf1Items1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1Items1?(BaseInputsOneOf1Items @this) => @this.BaseInputsOneOf1Items1;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items1? value)
        {
            BaseInputsOneOf1Items1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items2 value) => new BaseInputsOneOf1Items((global::OpenRouter.BaseInputsOneOf1Items2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1Items2?(BaseInputsOneOf1Items @this) => @this.BaseInputsOneOf1Items2;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items2? value)
        {
            BaseInputsOneOf1Items2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items3 value) => new BaseInputsOneOf1Items((global::OpenRouter.BaseInputsOneOf1Items3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.BaseInputsOneOf1Items3?(BaseInputsOneOf1Items @this) => @this.BaseInputsOneOf1Items3;

        /// <summary>
        /// 
        /// </summary>
        public BaseInputsOneOf1Items(global::OpenRouter.BaseInputsOneOf1Items3? value)
        {
            BaseInputsOneOf1Items3 = value;
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
            global::OpenRouter.BaseInputsOneOf1Items1? baseInputsOneOf1Items1,
            global::OpenRouter.BaseInputsOneOf1Items2? baseInputsOneOf1Items2,
            global::OpenRouter.BaseInputsOneOf1Items3? baseInputsOneOf1Items3,
            global::OpenRouter.OutputItemImageGenerationCall? outputItemImageGenerationCall,
            global::OpenRouter.OutputMessage? outputMessage
            )
        {
            BaseInputsOneOf1Items0 = baseInputsOneOf1Items0;
            BaseInputsOneOf1Items1 = baseInputsOneOf1Items1;
            BaseInputsOneOf1Items2 = baseInputsOneOf1Items2;
            BaseInputsOneOf1Items3 = baseInputsOneOf1Items3;
            OutputItemImageGenerationCall = outputItemImageGenerationCall;
            OutputMessage = outputMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            OutputMessage as object ??
            OutputItemImageGenerationCall as object ??
            BaseInputsOneOf1Items3 as object ??
            BaseInputsOneOf1Items2 as object ??
            BaseInputsOneOf1Items1 as object ??
            BaseInputsOneOf1Items0 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            BaseInputsOneOf1Items0?.ToString() ??
            BaseInputsOneOf1Items1?.ToString() ??
            BaseInputsOneOf1Items2?.ToString() ??
            BaseInputsOneOf1Items3?.ToString() ??
            OutputItemImageGenerationCall?.ToString() ??
            OutputMessage?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsBaseInputsOneOf1Items0 && !IsBaseInputsOneOf1Items1 && !IsBaseInputsOneOf1Items2 && !IsBaseInputsOneOf1Items3 && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && IsBaseInputsOneOf1Items1 && !IsBaseInputsOneOf1Items2 && !IsBaseInputsOneOf1Items3 && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsBaseInputsOneOf1Items1 && IsBaseInputsOneOf1Items2 && !IsBaseInputsOneOf1Items3 && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsBaseInputsOneOf1Items1 && !IsBaseInputsOneOf1Items2 && IsBaseInputsOneOf1Items3 && !IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsBaseInputsOneOf1Items1 && !IsBaseInputsOneOf1Items2 && !IsBaseInputsOneOf1Items3 && IsOutputItemImageGenerationCall && !IsOutputMessage || !IsBaseInputsOneOf1Items0 && !IsBaseInputsOneOf1Items1 && !IsBaseInputsOneOf1Items2 && !IsBaseInputsOneOf1Items3 && !IsOutputItemImageGenerationCall && IsOutputMessage;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.BaseInputsOneOf1Items0?, TResult>? baseInputsOneOf1Items0 = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1Items1?, TResult>? baseInputsOneOf1Items1 = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1Items2?, TResult>? baseInputsOneOf1Items2 = null,
            global::System.Func<global::OpenRouter.BaseInputsOneOf1Items3?, TResult>? baseInputsOneOf1Items3 = null,
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
            else if (IsBaseInputsOneOf1Items1 && baseInputsOneOf1Items1 != null)
            {
                return baseInputsOneOf1Items1(BaseInputsOneOf1Items1!);
            }
            else if (IsBaseInputsOneOf1Items2 && baseInputsOneOf1Items2 != null)
            {
                return baseInputsOneOf1Items2(BaseInputsOneOf1Items2!);
            }
            else if (IsBaseInputsOneOf1Items3 && baseInputsOneOf1Items3 != null)
            {
                return baseInputsOneOf1Items3(BaseInputsOneOf1Items3!);
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
            global::System.Action<global::OpenRouter.BaseInputsOneOf1Items1?>? baseInputsOneOf1Items1 = null,
            global::System.Action<global::OpenRouter.BaseInputsOneOf1Items2?>? baseInputsOneOf1Items2 = null,
            global::System.Action<global::OpenRouter.BaseInputsOneOf1Items3?>? baseInputsOneOf1Items3 = null,
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
            else if (IsBaseInputsOneOf1Items1)
            {
                baseInputsOneOf1Items1?.Invoke(BaseInputsOneOf1Items1!);
            }
            else if (IsBaseInputsOneOf1Items2)
            {
                baseInputsOneOf1Items2?.Invoke(BaseInputsOneOf1Items2!);
            }
            else if (IsBaseInputsOneOf1Items3)
            {
                baseInputsOneOf1Items3?.Invoke(BaseInputsOneOf1Items3!);
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
                BaseInputsOneOf1Items1,
                typeof(global::OpenRouter.BaseInputsOneOf1Items1),
                BaseInputsOneOf1Items2,
                typeof(global::OpenRouter.BaseInputsOneOf1Items2),
                BaseInputsOneOf1Items3,
                typeof(global::OpenRouter.BaseInputsOneOf1Items3),
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
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1Items1?>.Default.Equals(BaseInputsOneOf1Items1, other.BaseInputsOneOf1Items1) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1Items2?>.Default.Equals(BaseInputsOneOf1Items2, other.BaseInputsOneOf1Items2) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.BaseInputsOneOf1Items3?>.Default.Equals(BaseInputsOneOf1Items3, other.BaseInputsOneOf1Items3) &&
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
