#pragma warning disable CA1062 // Validate arguments of public methods

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System;
using System.Diagnostics.CodeAnalysis;

public class Test_DoesNotReturnAttribute {

    /// <summary>
    /// Line '<c>argument = argument.Trim()</c>' would fail with 'CA8602: Dereference of a possibly null reference' if method 
    /// <see cref="ThrowException(string)"/> would not be decorated with the <see cref="DoesNotReturnAttribute"/>.
    /// </summary>
    /// <param name="argument">An argument that should not be <see langword="null"/>.</param>
    public void DoSomething(string argument) {
        if (argument is null) ThrowException(nameof(argument));
        argument = argument.Trim();
        //Do more...
    }

    [DoesNotReturn]
    public void ThrowException(string parameterName) {
        throw new ArgumentNullException(parameterName, $"The argument for parameter '{parameterName}' is mandatory and may not be omitted!");
    }

}
