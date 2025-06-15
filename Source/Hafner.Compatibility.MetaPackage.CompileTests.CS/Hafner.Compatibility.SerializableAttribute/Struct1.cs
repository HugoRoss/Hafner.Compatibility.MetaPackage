//GuidAttribute on struct level

namespace Hafner.Compatibility.CompileTest.CS.SerializableAttribute;

using System;
using System.Runtime.InteropServices;

[Serializable]
public struct Struct1 : System.IEquatable<Struct1> {

    public int Value { get; set; }

    public override bool Equals(object? obj) {
        if (obj is not Struct1 other) return false;
        return Equals(other);
    }

    public bool Equals(Struct1 other) {
        return Value == other.Value;
    }

    public override int GetHashCode() {
        return Value;
    }

    public static bool operator ==(Struct1 left, Struct1 right) {
        return left.Equals(right);
    }

    public static bool operator !=(Struct1 left, Struct1 right) {
        return !left.Equals(right);
    }

}
