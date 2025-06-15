'GuidAttribute on delegate level

Imports System.Runtime.InteropServices

Namespace SerializableAttributeTests

    <Serializable>
    Public Delegate Function Serialize(Of T)(ByVal obj As T) As String

End Namespace
