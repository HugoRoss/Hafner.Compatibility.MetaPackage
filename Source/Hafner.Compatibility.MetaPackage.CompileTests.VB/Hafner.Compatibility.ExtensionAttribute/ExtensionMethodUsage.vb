Public NotInheritable Class ExtensionMethodUsage

    Public Shared Sub DoSomething()
        Dim list As New List(Of String) From {"a", "b", "c"}
        Dim hasElements As Boolean = list.HasElements()
    End Sub

End Class
