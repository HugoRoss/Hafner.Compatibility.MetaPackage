namespace Hafner.Compatibility.CompileTest.CS.ExtensionAttribute;

using System.Collections;
using System.Diagnostics.CodeAnalysis;

public static class EnumerableExtension {

    [SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "Would make the code messier!")]
    public static bool HasElements(this IEnumerable? enumerable) {
        if (enumerable is null) return false;
        return enumerable.GetEnumerator().MoveNext();
    }

}
