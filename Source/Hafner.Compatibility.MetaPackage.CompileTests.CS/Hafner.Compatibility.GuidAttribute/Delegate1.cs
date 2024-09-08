//GuidAttribute on delegate level

namespace Hafner.Compatibility.GuidAttribute.Tests;

using System.Runtime.InteropServices;

[Guid("24D47D52-666F-4ABE-AABA-250111ACD3E0")]
public delegate string Serialize<T>(T obj);
