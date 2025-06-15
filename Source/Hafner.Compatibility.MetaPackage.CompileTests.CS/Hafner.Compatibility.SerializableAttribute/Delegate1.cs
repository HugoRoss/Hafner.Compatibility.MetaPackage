//GuidAttribute on delegate level

namespace Hafner.Compatibility.CompileTest.CS.SerializableAttribute;

using System;
using System.Runtime.InteropServices;

[Serializable]
public delegate string Serialize<T>(T obj);
