'GuidAttribute on struct level

Imports System
Imports System.Runtime.InteropServices

Namespace SerializableAttributeTests

    <Serializable>
    Public Structure Struct1
        Implements IEquatable(Of Struct1)

        Public Property Value As Integer

        Public Overloads Overrides Function Equals(ByVal obj As Object) As Boolean
            If (TypeOf obj Is Struct1) Then
                Dim other As Struct1 = DirectCast(obj, Struct1)
                Return Equals(other)
            End If
            Return False
        End Function

        Public Overloads Function Equals(ByVal other As Struct1) As Boolean Implements IEquatable(Of Struct1).Equals
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
