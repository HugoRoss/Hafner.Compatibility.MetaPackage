#pragma warning disable CA2227 // Collection properties should be read only
#pragma warning disable CA1062 // Validate arguments of public methods

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public class Test_DisllowNullAttribute {

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private string? initiallyIsNull;

    /// <summary>
    /// Property that initially is unassigned but cannot be set to <see langword="null"/>.
    /// </summary>
    [DisallowNull]
    public string? InitiallyIsNull {
        get {
            return initiallyIsNull;
        }
        set {
            if (value is null) throw new ArgumentNullException(nameof(InitiallyIsNull), $"The property '{nameof(InitiallyIsNull)}' cannot be set to null!");
            initiallyIsNull = value;
        }
    }

}
