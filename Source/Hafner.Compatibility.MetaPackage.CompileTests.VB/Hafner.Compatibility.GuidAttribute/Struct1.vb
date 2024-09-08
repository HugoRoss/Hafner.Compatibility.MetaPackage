'GuidAttribute on struct level

Imports System
Imports System.Runtime.InteropServices

Namespace Hafner.Compatibility.GuidAttribute.Tests

    <GuidAttribute("B31D00F2-DA1F-40F5-BC34-4CCA21516920")>
    Public Structure Struct1
        Implements System.IEquatable(Of Struct1)

        Public Property Value As Integer

        Public Overrides Function Equals(ByVal obj As Object?) As Boolean
            If (obj Is Struct1) Then
                Dim other As Struct1 = DirectCast(obj, Struct1)
                Return Equals(other)
            End If
            Return False
        End Function

        Public Function Equals(ByVal other As Struct1) As Boolean
            Return Value = other.Value
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return Value
        End Function

        Public Shared Operator =(ByVal left As Struct1, ByVal right As Struct1) As Boolean
            Return left.Equals(right)
        End Operator

        Public Shared Operator <>(ByVal left As Struct1, ByVal right As Struct1) As Boolean
            Return Not left.Equals(right)
        End Operator

    End Structure

End Namespace
