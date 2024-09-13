#pragma warning disable CA1510

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System.Diagnostics.CodeAnalysis;

public class Test_NotNullAttribute {

    /// <summary>
    /// Line <c>'Value = value;'</c> would fail with a 'CS6801: Possible null reference assignment.' if method <see cref="NormalizeValue(ref string?)"/>
    /// would not decorate parameter 'value' with attribute <see cref="NotNullAttribute">NotNull</see>.
    /// </summary>
    /// <param name="value"></param>
    public Test_NotNullAttribute(string? value) {
        NormalizeValue(ref value);
        Value = value;
    }

    public string Value { get; }

    private static void NormalizeValue([NotNull] ref string? value) {
        value ??= string.Empty;
        if (value.Length > 0) {
            value = value.Trim();
        }
    }

}
