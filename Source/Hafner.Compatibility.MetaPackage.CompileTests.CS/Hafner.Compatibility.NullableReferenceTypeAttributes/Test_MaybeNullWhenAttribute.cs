#pragma warning disable CA1510

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public class Test_MaybeNullWhenAttribute {

    /// <summary>
    /// Adds or overwrites a given key/value pair.
    /// </summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public void Set(string key, object value) {
        if (key is null) throw new ArgumentNullException(nameof(key));
        if (value is null) throw new ArgumentNullException(nameof(value));
        _Dict[key] = value;
    }

    /// <summary>
    /// Forces the return value to be declared as '<c>object?</c>' even through with a List&lt;int&gt; int}"/> '<c>argument = argument.Trim()</c>' would fail with 'CA8602: Dereference of a possibly null reference' if argument 
    /// 'isNull' of method <see cref="ThrowExceptionIf(bool, string)"/> would not be decorated with the <see cref="DoesNotReturnIfAttribute"/>.
    /// </summary>
    /// <param name="key">The key who's value to look up.</param>
    /// <param name="value">The out parameter to receive the value found.</param>
    /// <returns><see langword="true"/> if found and assigned to the out-value, <see langword="false"/> otherwise.</returns>
    public bool TryGetValue(string key, [MaybeNullWhen(false)] out object value) {
        if (_Dict.TryGetValue(key, out value)) return true;
        return false;
    }

    private readonly Dictionary<string, object> _Dict = [];

}
