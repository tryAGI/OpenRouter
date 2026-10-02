#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace OpenRouter
{
    /// <summary>
    /// Only include batches created strictly after this timestamp.<br/>
    /// Example: 2026-08-20T00:00:00Z
    /// </summary>
    public readonly partial struct BatchListTimestamp : global::System.IEquatable<BatchListTimestamp>
    {
        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public string? BatchListTimestampVariant1 { get; init; }
#else
        public string? BatchListTimestampVariant1 { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(BatchListTimestampVariant1))]
#endif
        public bool IsBatchListTimestampVariant1 => BatchListTimestampVariant1 != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBatchListTimestampVariant1(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out string? value)
        {
            value = BatchListTimestampVariant1;
            return IsBatchListTimestampVariant1;
        }

        /// <summary>
        ///
        /// </summary>
        public string PickBatchListTimestampVariant1() => BatchListTimestampVariant1 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'BatchListTimestampVariant1' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.DateTime? DateTime { get; init; }
#else
        public global::System.DateTime? DateTime { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DateTime))]
#endif
        public bool IsDateTime => DateTime != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickDateTime(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.DateTime? value)
        {
            value = DateTime;
            return IsDateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime PickDateTime() => DateTime is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'DateTime' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator BatchListTimestamp(string value) => new BatchListTimestamp((string?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator string?(BatchListTimestamp @this) => @this.BatchListTimestampVariant1;

        /// <summary>
        ///
        /// </summary>
        public BatchListTimestamp(string? value)
        {
            BatchListTimestampVariant1 = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BatchListTimestamp FromBatchListTimestampVariant1(string? value) => new BatchListTimestamp(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator BatchListTimestamp(global::System.DateTime value) => new BatchListTimestamp((global::System.DateTime?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::System.DateTime?(BatchListTimestamp @this) => @this.DateTime;

        /// <summary>
        ///
        /// </summary>
        public BatchListTimestamp(global::System.DateTime? value)
        {
            DateTime = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static BatchListTimestamp FromDateTime(global::System.DateTime? value) => new BatchListTimestamp(value);

        /// <summary>
        ///
        /// </summary>
        public BatchListTimestamp(
            string? batchListTimestampVariant1,
            global::System.DateTime? dateTime
            )
        {
            BatchListTimestampVariant1 = batchListTimestampVariant1;
            DateTime = dateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            DateTime as object ??
            BatchListTimestampVariant1 as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            BatchListTimestampVariant1?.ToString() ??
            DateTime?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBatchListTimestampVariant1 || IsDateTime;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string, TResult>? batchListTimestampVariant1 = null,
            global::System.Func<global::System.DateTime?, TResult>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BatchListTimestampVariant1 is { } __value0 && batchListTimestampVariant1 != null)
            {
                return batchListTimestampVariant1(__value0);
            }
            else if (DateTime is { } __value1 && dateTime != null)
            {
                return dateTime(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<string>? batchListTimestampVariant1 = null,

            global::System.Action<global::System.DateTime?>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BatchListTimestampVariant1 is { } __value0)
            {
                batchListTimestampVariant1?.Invoke(__value0);
            }
            else if (DateTime is { } __value1)
            {
                dateTime?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<string>? batchListTimestampVariant1 = null,
            global::System.Action<global::System.DateTime?>? dateTime = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (BatchListTimestampVariant1 is { } __value0)
            {
                batchListTimestampVariant1?.Invoke(__value0);
            }
            else if (DateTime is { } __value1)
            {
                dateTime?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                BatchListTimestampVariant1,
                typeof(string),
                DateTime,
                typeof(global::System.DateTime),
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
        public bool Equals(BatchListTimestamp other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(BatchListTimestampVariant1, other.BatchListTimestampVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::System.DateTime?>.Default.Equals(DateTime, other.DateTime)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(BatchListTimestamp obj1, BatchListTimestamp obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<BatchListTimestamp>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(BatchListTimestamp obj1, BatchListTimestamp obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is BatchListTimestamp o && Equals(o);
        }
    }
}
