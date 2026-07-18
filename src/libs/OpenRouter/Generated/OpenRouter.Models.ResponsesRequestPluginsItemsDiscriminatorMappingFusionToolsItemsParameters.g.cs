#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters : global::System.IEquatable<ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 { get; init; }
#else
        public string? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 { get; init; }
#else
        public double? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 { get; init; }
#else
        public bool? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>> PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(string value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(string? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1(string? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(double value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(double? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2(double? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(bool value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(bool? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3(bool? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters((global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(
            string? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1,
            double? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2,
            bool? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3,
            global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3,
            global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4
            )
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3?.ToString().ToLowerInvariant() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = null,
            global::System.Func<double?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = null,
            global::System.Func<bool?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = null,

            global::System.Action<double?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = null,

            global::System.Action<bool?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = null,
            global::System.Action<double?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = null,
            global::System.Action<bool?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3 = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1,
                typeof(string),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2,
                typeof(double),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3,
                typeof(bool),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4),
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
        public bool Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.OneOf<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf3Items?, object>>?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters3) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters obj1, ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters obj1, ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters o && Equals(o);
        }
    }
}
