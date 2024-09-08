#pragma warning disable CA1034

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System.Diagnostics.CodeAnalysis;

public static class Test_MemberNotNullWhenAttribute {

    public sealed class Record1 {

        public string? RecordId { get; private set; }

        [MemberNotNullWhen(false, nameof(RecordId))]
        public bool IsNewRecord {
            get {
                return (RecordId is null);
            }
        }

        /// <summary>
        /// This method would raise a "CS8603: Possible null reference return." if <see cref="IsNewRecord"/> would not be decorated with the
        /// <see cref="MemberNotNullWhenAttribute">MemberNotNullWhen</see> attribute.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() {
            if (IsNewRecord) return "(new)";
            return RecordId;
        }

    }

    public sealed class Record2 {

        public string? RecordId { get; private set; }

        [MemberNotNullWhen(true, nameof(RecordId))]
        public bool IsExistingRecord {
            get {
                return (RecordId is not null);
            }
        }

        /// <summary>
        /// This method would raise a "CS8603: Possible null reference return." if <see cref="IsExistingRecord"/> would not be decorated with the
        /// <see cref="MemberNotNullWhenAttribute">MemberNotNullWhen</see> attribute.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public override string ToString() {
            if (IsExistingRecord) return RecordId;
            return "(new)";
        }

    }

}
