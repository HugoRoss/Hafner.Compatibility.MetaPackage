'GuidAttribute on delegate level

Imports System.Runtime.InteropServices

Namespace Hafner.Compatibility.GuidAttribute.Tests

    <GuidAttribute("24D47D52-666F-4ABE-AABA-250111ACD3E0")>
    Public Delegate Function Serialize(Of T)(ByVal obj As T) As String

End Namespace
