namespace Hafner.Compatibility.CompileTest.CS.NullableReferenceTypeAttributes;

using System;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "It's a test for an attribute!")]
public class Test_NotNullWhenAttribute {

    public void DoSomething(string value) {
        if (IsNullOrWhiteSpace(value)) throw new ArgumentNullException(nameof(value), $"Argument for parameter '{nameof(value)}' is mandatory and may not be null, empty or white-space!");
        value = value.Trim();
        //Do more...
        _ = value;
    }

    private static bool IsNullOrWhiteSpace([NotNullWhen(false)] string? value) {
        if (value is null) return true;
        if (value.Length == 0) return true;
        foreach (char c in value.ToCharArray()) {
            if (!Char.IsWhiteSpace(c)) return false;
        }
        return true;
    }

}
