#pragma warning disable CA1510

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

public class Test_MemberNotNullAttribute {

    /// <summary>
    /// The constructor would rise a "CS8618: Non-nullable property 'UniqueIdentifier' must contain a non-null value when exiting constructor. Consider declaring it as nullable."
    /// if method <see cref="InitializeUniqueIdentifier"/> would not be decorated with the <see cref="MemberNotNullAttribute">MemberNotNull</see> attribute.
    /// </summary>
    public Test_MemberNotNullAttribute() {
        InitializeUniqueIdentifier();
    }

    /// <summary>
    /// The constructor would rise a "CS8618: Non-nullable property 'UniqueIdentifier' must contain a non-null value when exiting constructor. Consider declaring it as nullable."
    /// if method <see cref="InitializeUniqueIdentifier"/> would not be decorated with the <see cref="MemberNotNullAttribute">MemberNotNull</see> attribute.
    /// </summary>
    /// <param name="message">Just an example argument.</param>
    public Test_MemberNotNullAttribute(string message) {
        InitializeUniqueIdentifier();
        Message = message;
    }

    [MemberNotNull(nameof(UniqueIdentifier))]
    private void InitializeUniqueIdentifier() {
        UniqueIdentifier = DateTime.Now.Ticks.ToString(CultureInfo.InvariantCulture);
    }

    public string UniqueIdentifier { get; private set; }

    public string? Message { get; }

}
