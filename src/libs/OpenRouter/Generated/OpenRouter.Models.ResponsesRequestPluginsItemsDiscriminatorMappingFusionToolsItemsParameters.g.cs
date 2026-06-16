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
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 { get; init; }
#else
        public object? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 { get; init; }
#else
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 { get; }
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
            out global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items> PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 { get; init; }
#else
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5' but the value was {ToString()}.");

        /// <summary>
        /// Any type
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 { get; init; }
#else
        public object? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7' but the value was {ToString()}.");
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
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters((global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters(
            string? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1,
            double? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2,
            bool? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3,
            object? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4,
            global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4,
            global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5,
            object? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7
            )
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 as object ??
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
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = null,
            global::System.Func<double?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = null,
            global::System.Func<bool?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = null,
            global::System.Func<object, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 = null,
            global::System.Func<global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,
            global::System.Func<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 = null,
            global::System.Func<object, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 = null,
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
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7!);
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

            global::System.Action<object>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 = null,

            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,

            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 = null,

            global::System.Action<object>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 = null,
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
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1 = null,
            global::System.Action<double?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2 = null,
            global::System.Action<bool?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3 = null,
            global::System.Action<object>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4 = null,
            global::System.Action<global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4 = null,
            global::System.Action<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5 = null,
            global::System.Action<object>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7 = null,
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
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7!);
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
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4,
                typeof(object),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4,
                typeof(global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5,
                typeof(global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7,
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
        public bool Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant3) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Items>?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters4) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParameters5) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersVariant7) 
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
