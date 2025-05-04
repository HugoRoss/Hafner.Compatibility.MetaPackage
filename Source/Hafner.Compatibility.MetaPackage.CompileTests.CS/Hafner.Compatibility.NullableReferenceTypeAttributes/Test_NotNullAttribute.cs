#pragma warning disable CA1510

namespace Hafner.Compatibility.CompileTest.CS.NullableReferenceTypeAttributes;

using System;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "It's a test for an attribute!")]
public class Test_NotNullAttribute {

    /// <summary>
    /// Line <c>'Value = value;'</c> would fail with a 'CS6801: Possible null reference assignment.' if method <see cref="NormalizeValue(ref String?)"/>
    /// would not decorate parameter 'value' with attribute <see cref="NotNullAttribute">NotNull</see>.
    /// </summary>
    /// <param name="value"></param>
    public Test_NotNullAttribute(string? value) {
        NormalizeValue(ref value);
        Value = value;
    }

    public string Value { get; }

    private static void NormalizeValue([NotNull] ref string? value) {
        value ??= String.Empty;
        if (value.Length > 0) {
            value = value.Trim();
        }
    }

}
