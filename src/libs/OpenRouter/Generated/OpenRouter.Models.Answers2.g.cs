#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// One answer per requested field. `value` is null when the state does not determine it.
    /// </summary>
    public readonly partial struct Answers2 : global::System.IEquatable<Answers2>
    {
        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionTextAnswer? Text { get; init; }
#else
        public global::OpenRouter.ExtractionTextAnswer? Text { get; }
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
            out global::OpenRouter.ExtractionTextAnswer? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTextAnswer PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionNumberAnswer? Number { get; init; }
#else
        public global::OpenRouter.ExtractionNumberAnswer? Number { get; }
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
            out global::OpenRouter.ExtractionNumberAnswer? value)
        {
            value = Number;
            return IsNumber;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionNumberAnswer PickNumber() => Number is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Number' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDateAnswer? Date { get; init; }
#else
        public global::OpenRouter.ExtractionDateAnswer? Date { get; }
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
            out global::OpenRouter.ExtractionDateAnswer? value)
        {
            value = Date;
            return IsDate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDateAnswer PickDate() => Date is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Date' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionTimeAnswer? Time { get; init; }
#else
        public global::OpenRouter.ExtractionTimeAnswer? Time { get; }
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
            out global::OpenRouter.ExtractionTimeAnswer? value)
        {
            value = Time;
            return IsTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionTimeAnswer PickTime() => Time is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Time' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDatetimeAnswer? Datetime { get; init; }
#else
        public global::OpenRouter.ExtractionDatetimeAnswer? Datetime { get; }
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
            out global::OpenRouter.ExtractionDatetimeAnswer? value)
        {
            value = Datetime;
            return IsDatetime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDatetimeAnswer PickDatetime() => Datetime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Datetime' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionDurationAnswer? Duration { get; init; }
#else
        public global::OpenRouter.ExtractionDurationAnswer? Duration { get; }
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
            out global::OpenRouter.ExtractionDurationAnswer? value)
        {
            value = Duration;
            return IsDuration;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionDurationAnswer PickDuration() => Duration is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Duration' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionListAnswer? List { get; init; }
#else
        public global::OpenRouter.ExtractionListAnswer? List { get; }
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
            out global::OpenRouter.ExtractionListAnswer? value)
        {
            value = List;
            return IsList;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionListAnswer PickList() => List is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'List' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionEstimateAnswer? Estimate { get; init; }
#else
        public global::OpenRouter.ExtractionEstimateAnswer? Estimate { get; }
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
            out global::OpenRouter.ExtractionEstimateAnswer? value)
        {
            value = Estimate;
            return IsEstimate;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionEstimateAnswer PickEstimate() => Estimate is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Estimate' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::OpenRouter.ExtractionForecastAnswer? Forecast { get; init; }
#else
        public global::OpenRouter.ExtractionForecastAnswer? Forecast { get; }
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
            out global::OpenRouter.ExtractionForecastAnswer? value)
        {
            value = Forecast;
            return IsForecast;
        }

        /// <summary>
        ///
        /// </summary>
        public global::OpenRouter.ExtractionForecastAnswer PickForecast() => Forecast is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Forecast' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionTextAnswer value) => new Answers2((global::OpenRouter.ExtractionTextAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionTextAnswer?(Answers2 @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionTextAnswer? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromText(global::OpenRouter.ExtractionTextAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionNumberAnswer value) => new Answers2((global::OpenRouter.ExtractionNumberAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionNumberAnswer?(Answers2 @this) => @this.Number;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionNumberAnswer? value)
        {
            Number = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromNumber(global::OpenRouter.ExtractionNumberAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionDateAnswer value) => new Answers2((global::OpenRouter.ExtractionDateAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDateAnswer?(Answers2 @this) => @this.Date;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionDateAnswer? value)
        {
            Date = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromDate(global::OpenRouter.ExtractionDateAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionTimeAnswer value) => new Answers2((global::OpenRouter.ExtractionTimeAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionTimeAnswer?(Answers2 @this) => @this.Time;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionTimeAnswer? value)
        {
            Time = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromTime(global::OpenRouter.ExtractionTimeAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionDatetimeAnswer value) => new Answers2((global::OpenRouter.ExtractionDatetimeAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDatetimeAnswer?(Answers2 @this) => @this.Datetime;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionDatetimeAnswer? value)
        {
            Datetime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromDatetime(global::OpenRouter.ExtractionDatetimeAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionDurationAnswer value) => new Answers2((global::OpenRouter.ExtractionDurationAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionDurationAnswer?(Answers2 @this) => @this.Duration;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionDurationAnswer? value)
        {
            Duration = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromDuration(global::OpenRouter.ExtractionDurationAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionListAnswer value) => new Answers2((global::OpenRouter.ExtractionListAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionListAnswer?(Answers2 @this) => @this.List;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionListAnswer? value)
        {
            List = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromList(global::OpenRouter.ExtractionListAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionEstimateAnswer value) => new Answers2((global::OpenRouter.ExtractionEstimateAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionEstimateAnswer?(Answers2 @this) => @this.Estimate;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionEstimateAnswer? value)
        {
            Estimate = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromEstimate(global::OpenRouter.ExtractionEstimateAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator Answers2(global::OpenRouter.ExtractionForecastAnswer value) => new Answers2((global::OpenRouter.ExtractionForecastAnswer?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::OpenRouter.ExtractionForecastAnswer?(Answers2 @this) => @this.Forecast;

        /// <summary>
        ///
        /// </summary>
        public Answers2(global::OpenRouter.ExtractionForecastAnswer? value)
        {
            Forecast = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static Answers2 FromForecast(global::OpenRouter.ExtractionForecastAnswer? value) => new Answers2(value);

        /// <summary>
        ///
        /// </summary>
        public Answers2(
            global::OpenRouter.ExtractionsResponseAnswersDiscriminatorType? type,
            global::OpenRouter.ExtractionTextAnswer? text,
            global::OpenRouter.ExtractionNumberAnswer? number,
            global::OpenRouter.ExtractionDateAnswer? date,
            global::OpenRouter.ExtractionTimeAnswer? time,
            global::OpenRouter.ExtractionDatetimeAnswer? datetime,
            global::OpenRouter.ExtractionDurationAnswer? duration,
            global::OpenRouter.ExtractionListAnswer? list,
            global::OpenRouter.ExtractionEstimateAnswer? estimate,
            global::OpenRouter.ExtractionForecastAnswer? forecast
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
            global::System.Func<global::OpenRouter.ExtractionTextAnswer, TResult>? text = null,
            global::System.Func<global::OpenRouter.ExtractionNumberAnswer, TResult>? number = null,
            global::System.Func<global::OpenRouter.ExtractionDateAnswer, TResult>? date = null,
            global::System.Func<global::OpenRouter.ExtractionTimeAnswer, TResult>? time = null,
            global::System.Func<global::OpenRouter.ExtractionDatetimeAnswer, TResult>? datetime = null,
            global::System.Func<global::OpenRouter.ExtractionDurationAnswer, TResult>? duration = null,
            global::System.Func<global::OpenRouter.ExtractionListAnswer, TResult>? list = null,
            global::System.Func<global::OpenRouter.ExtractionEstimateAnswer, TResult>? estimate = null,
            global::System.Func<global::OpenRouter.ExtractionForecastAnswer, TResult>? forecast = null,
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
            global::System.Action<global::OpenRouter.ExtractionTextAnswer>? text = null,

            global::System.Action<global::OpenRouter.ExtractionNumberAnswer>? number = null,

            global::System.Action<global::OpenRouter.ExtractionDateAnswer>? date = null,

            global::System.Action<global::OpenRouter.ExtractionTimeAnswer>? time = null,

            global::System.Action<global::OpenRouter.ExtractionDatetimeAnswer>? datetime = null,

            global::System.Action<global::OpenRouter.ExtractionDurationAnswer>? duration = null,

            global::System.Action<global::OpenRouter.ExtractionListAnswer>? list = null,

            global::System.Action<global::OpenRouter.ExtractionEstimateAnswer>? estimate = null,

            global::System.Action<global::OpenRouter.ExtractionForecastAnswer>? forecast = null,
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
            global::System.Action<global::OpenRouter.ExtractionTextAnswer>? text = null,
            global::System.Action<global::OpenRouter.ExtractionNumberAnswer>? number = null,
            global::System.Action<global::OpenRouter.ExtractionDateAnswer>? date = null,
            global::System.Action<global::OpenRouter.ExtractionTimeAnswer>? time = null,
            global::System.Action<global::OpenRouter.ExtractionDatetimeAnswer>? datetime = null,
            global::System.Action<global::OpenRouter.ExtractionDurationAnswer>? duration = null,
            global::System.Action<global::OpenRouter.ExtractionListAnswer>? list = null,
            global::System.Action<global::OpenRouter.ExtractionEstimateAnswer>? estimate = null,
            global::System.Action<global::OpenRouter.ExtractionForecastAnswer>? forecast = null,
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
                typeof(global::OpenRouter.ExtractionTextAnswer),
                Number,
                typeof(global::OpenRouter.ExtractionNumberAnswer),
                Date,
                typeof(global::OpenRouter.ExtractionDateAnswer),
                Time,
                typeof(global::OpenRouter.ExtractionTimeAnswer),
                Datetime,
                typeof(global::OpenRouter.ExtractionDatetimeAnswer),
                Duration,
                typeof(global::OpenRouter.ExtractionDurationAnswer),
                List,
                typeof(global::OpenRouter.ExtractionListAnswer),
                Estimate,
                typeof(global::OpenRouter.ExtractionEstimateAnswer),
                Forecast,
                typeof(global::OpenRouter.ExtractionForecastAnswer),
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
        public bool Equals(Answers2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionTextAnswer?>.Default.Equals(Text, other.Text) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionNumberAnswer?>.Default.Equals(Number, other.Number) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDateAnswer?>.Default.Equals(Date, other.Date) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionTimeAnswer?>.Default.Equals(Time, other.Time) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDatetimeAnswer?>.Default.Equals(Datetime, other.Datetime) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionDurationAnswer?>.Default.Equals(Duration, other.Duration) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionListAnswer?>.Default.Equals(List, other.List) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionEstimateAnswer?>.Default.Equals(Estimate, other.Estimate) &&
                global::System.Collections.Generic.EqualityComparer<global::OpenRouter.ExtractionForecastAnswer?>.Default.Equals(Forecast, other.Forecast)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(Answers2 obj1, Answers2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Answers2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(Answers2 obj1, Answers2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Answers2 o && Equals(o);
        }
    }
}
