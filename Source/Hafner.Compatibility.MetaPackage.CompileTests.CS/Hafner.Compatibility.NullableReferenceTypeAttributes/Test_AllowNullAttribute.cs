#pragma warning disable CA2227 // Collection properties should be read only

namespace Hafner.Compatibility.CompileTest.CS.NullableReferenceTypeAttributes;

using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Naming", "CA1711:Identifiers should not have incorrect suffix", Justification = "It's a test for an attribute!")]
public class Test_AllowNullAttribute {

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    private List<string>? neverNull;

    /// <summary>
    /// Property that never returns null but allows null to be assigned to clear the cached value and reset it to its default.
    /// </summary>
    [AllowNull]
    public List<string> NeverNull {
        get {
            List<string>? result = neverNull;
            if (result is null) {
                neverNull = result = [];
            }
            return result;
        }
        set => neverNull = value;
    }

}
