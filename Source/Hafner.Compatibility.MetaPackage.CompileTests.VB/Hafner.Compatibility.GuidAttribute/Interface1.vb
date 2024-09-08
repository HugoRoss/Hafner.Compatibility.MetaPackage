'GuidAttribute on interface level

Imports System.Runtime.InteropServices

Namespace Hafner.Compatibility.GuidAttribute.Tests

    <GuidAttribute("74EF5210-4624-4E3C-88F3-2B2E4A2CE3D0")>
    Interface IInterface1
        Private ReadOnly Property Name As String
    End Interface

End Namespace
