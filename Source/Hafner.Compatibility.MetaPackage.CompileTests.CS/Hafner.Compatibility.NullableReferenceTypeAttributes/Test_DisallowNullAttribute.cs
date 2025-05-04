#pragma warning disable CA2227 // Collection properties should be read only
#pragma warning disable CA1062 // Validate arguments of public methods

namespace Hafner.Compatibility.CompileTest.CS.NullableReferenceTypeAttributes;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "It's a test for an attribute!")]
public class Test_DisallowNullAttribute {

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string? initiallyIsNull;

    /// <summary>
    /// Property that initially is unassigned but cannot be set to <see langword="null"/>.
    /// </summary>
    [DisallowNull]
    public string? InitiallyIsNull {
        get => initiallyIsNull;
        set {
            if (value is null) throw new ArgumentNullException(nameof(InitiallyIsNull), $"The property '{nameof(InitiallyIsNull)}' cannot be set to null!");
            initiallyIsNull = value;
        }
    }

}
