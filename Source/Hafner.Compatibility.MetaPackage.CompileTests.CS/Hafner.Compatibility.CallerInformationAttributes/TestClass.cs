namespace Hafner.Compatibility.CompileTest.CS.CallerInformationAttributes;

using System.Runtime.CompilerServices;

public static class TestClass {

    public static string GetCallerInfoG1([CallerFilePath] string filePath = "",
                               [CallerLineNumber] int lineNumber = 0,
                               [CallerMemberName] string memberName = "") {
        return $"File: {filePath}, Line: {lineNumber}, Member: {memberName}";
    }

    public static string GetCallerInfoG2(string arg1, int arg2, [CallerArgumentExpression(nameof(arg1))] string arg1Name = "", [CallerArgumentExpression(nameof(arg2))] string arg2Name = "") {
        return $"Name/expression of arg1: {arg1Name}, Name/expression of arg2: {arg2Name}";
    }

}
