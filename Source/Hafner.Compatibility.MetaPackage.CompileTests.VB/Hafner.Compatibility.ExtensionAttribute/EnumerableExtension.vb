Imports System.Runtime.CompilerServices

Public Module EnumerableExtension

    <Extension>
    Function HasElements(enumerable As IEnumerable) As Boolean
        If (enumerable Is Nothing) Then Return False
        Return enumerable.GetEnumerator().MoveNext()
    End Function

End Module
