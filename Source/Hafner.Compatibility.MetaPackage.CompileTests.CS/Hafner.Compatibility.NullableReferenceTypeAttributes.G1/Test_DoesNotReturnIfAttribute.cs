#pragma warning disable CA2227 // Collection properties should be read only
#pragma warning disable CA1062 // Validate arguments of public methods

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

public class Test_DoesNotReturnIfAttribute {

    /// <summary>
    /// Line '<c>argument = argument.Trim()</c>' would fail with 'CA8602: Dereference of a possibly null reference' if argument 
    /// 'isNull' of method <see cref="ThrowExceptionIf(bool, string)"/> would not be decorated with the <see cref="DoesNotReturnIfAttribute"/>.
    /// </summary>
    /// <param name="argument">An argument that should not be <see langword="null"/>.</param>
    public void DoSomething(string argument) {
        ThrowExceptionIf(argument is null, nameof(argument));
        argument = argument.Trim();
        //Do more...
    }

    private static void ThrowExceptionIf([DoesNotReturnIf(true)] bool isNull, string parameterName) {
        if (isNull) throw new ArgumentNullException(parameterName, $"The argument for parameter '{parameterName}' is mandatory and may not be null!");
    }

    /// <summary>
    /// Line '<c>argument = argument.Trim()</c>' would fail with 'CA8602: Dereference of a possibly null reference' if argument
    /// 'hasValue' of method <see cref="EnsureThat(bool, string)"/> would not be decorated with the <see cref="DoesNotReturnIfAttribute"/>.
    /// </summary>
    /// <param name="argument">An argument that should not be <see langword="null"/>.</param>
    public void DoSomething2(string argument) {
        EnsureThat(argument is not null, nameof(argument));
        argument = argument.Trim();
        //Do more...
    }

    public void EnsureThat([DoesNotReturnIf(false)] bool hasValue, string parameterName) {
        if (!hasValue) throw new ArgumentNullException(parameterName, $"The argument for parameter '{parameterName}' is mandatory and may not be null!");
    }

}
