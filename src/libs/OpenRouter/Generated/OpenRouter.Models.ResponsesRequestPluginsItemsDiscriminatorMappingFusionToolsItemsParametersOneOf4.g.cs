#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 : global::System.IEquatable<ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 { get; init; }
#else
        public string? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1;
        }

        /// <summary>
        /// 
        /// </summary>
        public string PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 { get; init; }
#else
        public double? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out double? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public double PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public bool? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 { get; init; }
#else
        public bool? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3))]
#endif
        public bool IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 => ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out bool? value)
        {
            value = ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3;
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public bool PickResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3() => IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3
            ? ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3!.Value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(string value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(string? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1(string? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(double value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(double? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2(double? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(bool value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4((bool?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator bool?(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 @this) => @this.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3;

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(bool? value)
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 FromResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3(bool? value) => new ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(value);

        /// <summary>
        /// 
        /// </summary>
        public ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4(
            string? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1,
            double? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2,
            bool? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3
            )
        {
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2;
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 = responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 as object ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2?.ToString() ??
            ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3?.ToString().ToLowerInvariant() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 || !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 && !IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 && IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 = null,
            global::System.Func<double?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 = null,
            global::System.Func<bool?, TResult>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 && responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 != null)
            {
                return responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 = null,

            global::System.Action<double?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 = null,

            global::System.Action<bool?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<string>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1 = null,
            global::System.Action<double?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2 = null,
            global::System.Action<bool?>? responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2!);
            }
            else if (IsResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3)
            {
                responsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3?.Invoke(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1,
                typeof(string),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2,
                typeof(double),
                ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3,
                typeof(bool),
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
        public bool Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant2) &&
                global::System.Collections.Generic.EqualityComparer<bool?>.Default.Equals(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3, other.ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4Variant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 obj1, ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 obj1, ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ResponsesRequestPluginsItemsDiscriminatorMappingFusionToolsItemsParametersOneOf4 o && Equals(o);
        }
    }
}
