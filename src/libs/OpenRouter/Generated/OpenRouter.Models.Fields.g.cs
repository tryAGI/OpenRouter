#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// A typed field to extract, compute, estimate or forecast from the state. Which types a model answers is model-specific; unsupported types are rejected with 400.
    /// </summary>
    public readonly partial struct Fields : global::System.IEquatable<Fields>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionTextField? Text { get; init; }
#else
        public global::OpenRouter.ExtractionTextField? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionTextField? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextField PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionNumberField? Number { get; init; }
#else
        public global::OpenRouter.ExtractionNumberField? Number { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Number))]
#endif
        public bool IsNumber => Number != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickNumber(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionNumberField? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberField PickNumber() => Number is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDateField? Date { get; init; }
#else
        public global::OpenRouter.ExtractionDateField? Date { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Date))]
#endif
        public bool IsDate => Date != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionDateField? value)
        {
            value = Date;
            return IsDate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateField PickDate() => Date is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Date' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionTimeField? Time { get; init; }
#else
        public global::OpenRouter.ExtractionTimeField? Time { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Time))]
#endif
        public bool IsTime => Time != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionTimeField? value)
        {
            value = Time;
            return IsTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeField PickTime() => Time is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Time' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDatetimeField? Datetime { get; init; }
#else
        public global::OpenRouter.ExtractionDatetimeField? Datetime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Datetime))]
#endif
        public bool IsDatetime => Datetime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDatetime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionDatetimeField? value)
        {
            value = Datetime;
            return IsDatetime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeField PickDatetime() => Datetime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datetime' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDurationField? Duration { get; init; }
#else
        public global::OpenRouter.ExtractionDurationField? Duration { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Duration))]
#endif
        public bool IsDuration => Duration != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDuration(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionDurationField? value)
        {
            value = Duration;
            return IsDuration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationField PickDuration() => Duration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Duration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionListField? List { get; init; }
#else
        public global::OpenRouter.ExtractionListField? List { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(List))]
#endif
        public bool IsList => List != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickList(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionListField? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListField PickList() => List is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionEstimateField? Estimate { get; init; }
#else
        public global::OpenRouter.ExtractionEstimateField? Estimate { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Estimate))]
#endif
        public bool IsEstimate => Estimate != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickEstimate(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionEstimateField? value)
        {
            value = Estimate;
            return IsEstimate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateField PickEstimate() => Estimate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Estimate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionForecastField? Forecast { get; init; }
#else
        public global::OpenRouter.ExtractionForecastField? Forecast { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Forecast))]
#endif
        public bool IsForecast => Forecast != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickForecast(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::OpenRouter.ExtractionForecastField? value)
        {
            value = Forecast;
            return IsForecast;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastField PickForecast() => Forecast is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Forecast' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionTextField value) => new Fields((global::OpenRouter.ExtractionTextField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionTextField?(Fields @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionTextField? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromText(global::OpenRouter.ExtractionTextField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionNumberField value) => new Fields((global::OpenRouter.ExtractionNumberField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionNumberField?(Fields @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionNumberField? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromNumber(global::OpenRouter.ExtractionNumberField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionDateField value) => new Fields((global::OpenRouter.ExtractionDateField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDateField?(Fields @this) => @this.Date;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionDateField? value)
        {
            Date = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromDate(global::OpenRouter.ExtractionDateField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionTimeField value) => new Fields((global::OpenRouter.ExtractionTimeField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionTimeField?(Fields @this) => @this.Time;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionTimeField? value)
        {
            Time = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromTime(global::OpenRouter.ExtractionTimeField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionDatetimeField value) => new Fields((global::OpenRouter.ExtractionDatetimeField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDatetimeField?(Fields @this) => @this.Datetime;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionDatetimeField? value)
        {
            Datetime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromDatetime(global::OpenRouter.ExtractionDatetimeField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionDurationField value) => new Fields((global::OpenRouter.ExtractionDurationField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDurationField?(Fields @this) => @this.Duration;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionDurationField? value)
        {
            Duration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromDuration(global::OpenRouter.ExtractionDurationField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionListField value) => new Fields((global::OpenRouter.ExtractionListField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionListField?(Fields @this) => @this.List;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionListField? value)
        {
            List = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromList(global::OpenRouter.ExtractionListField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionEstimateField value) => new Fields((global::OpenRouter.ExtractionEstimateField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionEstimateField?(Fields @this) => @this.Estimate;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionEstimateField? value)
        {
            Estimate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromEstimate(global::OpenRouter.ExtractionEstimateField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Fields(global::OpenRouter.ExtractionForecastField value) => new Fields((global::OpenRouter.ExtractionForecastField?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionForecastField?(Fields @this) => @this.Forecast;

        /// <summary>
        ///
        /// </summary>
        public Fields(global::OpenRouter.ExtractionForecastField? value)
        {
            Forecast = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Fields FromForecast(global::OpenRouter.ExtractionForecastField? value) => new Fields(value);

        /// <summary>
        ///
        /// </summary>
        public Fields(
            global::OpenRouter.ExtractionsRequestFieldsDiscriminatorType? type,
            global::OpenRouter.ExtractionTextField? text,
            global::OpenRouter.ExtractionNumberField? number,
            global::OpenRouter.ExtractionDateField? date,
            global::OpenRouter.ExtractionTimeField? time,
            global::OpenRouter.ExtractionDatetimeField? datetime,
            global::OpenRouter.ExtractionDurationField? duration,
            global::OpenRouter.ExtractionListField? list,
            global::OpenRouter.ExtractionEstimateField? estimate,
            global::OpenRouter.ExtractionForecastField? forecast
            )
        {
            Type = type;

            Text = text;
            Number = number;
            Date = date;
            Time = time;
            Datetime = datetime;
            Duration = duration;
            List = list;
            Estimate = estimate;
            Forecast = forecast;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Forecast as object ??
            Estimate as object ??
            List as object ??
            Duration as object ??
            Datetime as object ??
            Time as object ??
            Date as object ??
            Number as object ??
            Text as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Text?.ToString() ??
            Number?.ToString() ??
            Date?.ToString() ??
            Time?.ToString() ??
            Datetime?.ToString() ??
            Duration?.ToString() ??
            List?.ToString() ??
            Estimate?.ToString() ??
            Forecast?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsText && !IsNumber && !IsDate && !IsTime && !IsDatetime && !IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && IsNumber && !IsDate && !IsTime && !IsDatetime && !IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && IsDate && !IsTime && !IsDatetime && !IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && IsTime && !IsDatetime && !IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && !IsTime && IsDatetime && !IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && !IsTime && !IsDatetime && IsDuration && !IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && !IsTime && !IsDatetime && !IsDuration && IsList && !IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && !IsTime && !IsDatetime && !IsDuration && !IsList && IsEstimate && !IsForecast || !IsText && !IsNumber && !IsDate && !IsTime && !IsDatetime && !IsDuration && !IsList && !IsEstimate && IsForecast;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::OpenRouter.ExtractionTextField, TResult>? text = null,
            global::System.Func<global::OpenRouter.ExtractionNumberField, TResult>? number = null,
            global::System.Func<global::OpenRouter.ExtractionDateField, TResult>? date = null,
            global::System.Func<global::OpenRouter.ExtractionTimeField, TResult>? time = null,
            global::System.Func<global::OpenRouter.ExtractionDatetimeField, TResult>? datetime = null,
            global::System.Func<global::OpenRouter.ExtractionDurationField, TResult>? duration = null,
            global::System.Func<global::OpenRouter.ExtractionListField, TResult>? list = null,
            global::System.Func<global::OpenRouter.ExtractionEstimateField, TResult>? estimate = null,
            global::System.Func<global::OpenRouter.ExtractionForecastField, TResult>? forecast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0 && text != null)
            {
                return text(__value0);
            }
            else if (Number is { } __value1 && number != null)
            {
                return number(__value1);
            }
            else if (Date is { } __value2 && date != null)
            {
                return date(__value2);
            }
            else if (Time is { } __value3 && time != null)
            {
                return time(__value3);
            }
            else if (Datetime is { } __value4 && datetime != null)
            {
                return datetime(__value4);
            }
            else if (Duration is { } __value5 && duration != null)
            {
                return duration(__value5);
            }
            else if (List is { } __value6 && list != null)
            {
                return list(__value6);
            }
            else if (Estimate is { } __value7 && estimate != null)
            {
                return estimate(__value7);
            }
            else if (Forecast is { } __value8 && forecast != null)
            {
                return forecast(__value8);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::OpenRouter.ExtractionTextField>? text = null,

            global::System.Action<global::OpenRouter.ExtractionNumberField>? number = null,

            global::System.Action<global::OpenRouter.ExtractionDateField>? date = null,

            global::System.Action<global::OpenRouter.ExtractionTimeField>? time = null,

            global::System.Action<global::OpenRouter.ExtractionDatetimeField>? datetime = null,

            global::System.Action<global::OpenRouter.ExtractionDurationField>? duration = null,

            global::System.Action<global::OpenRouter.ExtractionListField>? list = null,

            global::System.Action<global::OpenRouter.ExtractionEstimateField>? estimate = null,

            global::System.Action<global::OpenRouter.ExtractionForecastField>? forecast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Number is { } __value1)
            {
                number?.Invoke(__value1);
            }
            else if (Date is { } __value2)
            {
                date?.Invoke(__value2);
            }
            else if (Time is { } __value3)
            {
                time?.Invoke(__value3);
            }
            else if (Datetime is { } __value4)
            {
                datetime?.Invoke(__value4);
            }
            else if (Duration is { } __value5)
            {
                duration?.Invoke(__value5);
            }
            else if (List is { } __value6)
            {
                list?.Invoke(__value6);
            }
            else if (Estimate is { } __value7)
            {
                estimate?.Invoke(__value7);
            }
            else if (Forecast is { } __value8)
            {
                forecast?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::OpenRouter.ExtractionTextField>? text = null,
            global::System.Action<global::OpenRouter.ExtractionNumberField>? number = null,
            global::System.Action<global::OpenRouter.ExtractionDateField>? date = null,
            global::System.Action<global::OpenRouter.ExtractionTimeField>? time = null,
            global::System.Action<global::OpenRouter.ExtractionDatetimeField>? datetime = null,
            global::System.Action<global::OpenRouter.ExtractionDurationField>? duration = null,
            global::System.Action<global::OpenRouter.ExtractionListField>? list = null,
            global::System.Action<global::OpenRouter.ExtractionEstimateField>? estimate = null,
            global::System.Action<global::OpenRouter.ExtractionForecastField>? forecast = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Text is { } __value0)
            {
                text?.Invoke(__value0);
            }
            else if (Number is { } __value1)
            {
                number?.Invoke(__value1);
            }
            else if (Date is { } __value2)
            {
                date?.Invoke(__value2);
            }
            else if (Time is { } __value3)
            {
                time?.Invoke(__value3);
            }
            else if (Datetime is { } __value4)
            {
                datetime?.Invoke(__value4);
            }
            else if (Duration is { } __value5)
            {
                duration?.Invoke(__value5);
            }
            else if (List is { } __value6)
            {
                list?.Invoke(__value6);
            }
            else if (Estimate is { } __value7)
            {
                estimate?.Invoke(__value7);
            }
            else if (Forecast is { } __value8)
            {
                forecast?.Invoke(__value8);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Text,
                typeof(global::OpenRouter.ExtractionTextField),
                Number,
                typeof(global::OpenRouter.ExtractionNumberField),
                Date,
                typeof(global::OpenRouter.ExtractionDateField),
                Time,
                typeof(global::OpenRouter.ExtractionTimeField),
                Datetime,
                typeof(global::OpenRouter.ExtractionDatetimeField),
                Duration,
                typeof(global::OpenRouter.ExtractionDurationField),
                List,
                typeof(global::OpenRouter.ExtractionListField),
                Estimate,
                typeof(global::OpenRouter.ExtractionEstimateField),
                Forecast,
                typeof(global::OpenRouter.ExtractionForecastField),
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
        public bool Equals(Fields other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionTextField?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionNumberField?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDateField?>.Default.Equals(Date, other.Date) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionTimeField?>.Default.Equals(Time, other.Time) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDatetimeField?>.Default.Equals(Datetime, other.Datetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDurationField?>.Default.Equals(Duration, other.Duration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionListField?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionEstimateField?>.Default.Equals(Estimate, other.Estimate) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionForecastField?>.Default.Equals(Forecast, other.Forecast)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Fields obj1, Fields obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Fields>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Fields obj1, Fields obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Fields o && Equals(o);
        }
    }
}
