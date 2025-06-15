Imports System.Runtime.CompilerServices

Namespace CallerInformationAttributesTests

    Public Class TestClass

        Public Shared Function GetCallerInfoG1(<CallerFilePath> Optional filePath As String = "",
                                               <CallerLineNumber> Optional lineNumber As Int32 = 0,
                                               <CallerMemberName> Optional memberName As String = "") As String

            Return $"File: {filePath}, Line: {lineNumber}, Member: {memberName}"
        End Function

        Public Shared Function GetCallerInfoG2(arg1 As String,
                                               arg2 As Int32,
                                               <CallerArgumentExpression("arg1")> arg1Name As String,
                                               <CallerArgumentExpression("arg2")> arg2Name As String) As String

            Return $"Name/expression of arg1: {arg1Name}, Name/expression of arg2: {arg2Name}"
        End Function

    End Class

End Namespace
