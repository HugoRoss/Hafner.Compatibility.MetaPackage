//GuidAttribute on struct level

namespace Hafner.Compatibility.GuidAttribute.Tests;

using System.Runtime.InteropServices;

[Guid("B31D00F2-DA1F-40F5-BC34-4CCA21516920")]
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
