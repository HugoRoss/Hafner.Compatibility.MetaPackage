//GuidAttribute on class level

namespace Hafner.Compatibility.CompileTest.CS.SerializableAttribute;

using System;
using System.Runtime.InteropServices;

[Serializable]
public class Class1 {

    public string? Name { get; set; }

}
