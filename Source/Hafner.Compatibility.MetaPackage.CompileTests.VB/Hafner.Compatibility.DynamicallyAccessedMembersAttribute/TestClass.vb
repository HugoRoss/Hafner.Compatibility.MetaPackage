Imports System
Imports System.Diagnostics.CodeAnalysis

Namespace DynamicallyAccessedMembersTests

    Public NotInheritable Class TestClass

        <RequiresUnreferencedCode("This is just a compile test.")>
        Public Shared Sub MethodThatDoesNotSupportTrimming()
            Throw New NotImplementedException()
        End Sub

        Public Shared Sub Method1()
            Method2(Of DateTime)()
        End Sub

        Public Shared Sub Method2(Of T)()
            Dim type As Type = GetType(T)
            Method3(type)
        End Sub

        Public Shared Sub Method3(<DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)> type As Type)
            'Do something with it
            If (type Is Nothing) Then Throw New ArgumentNullException(NameOf(type))
            type.ToString()
        End Sub

        <DynamicDependency(NameOf(Method3))>
        Public Shared Sub Method4()
        End Sub

    End Class

End Namespace
