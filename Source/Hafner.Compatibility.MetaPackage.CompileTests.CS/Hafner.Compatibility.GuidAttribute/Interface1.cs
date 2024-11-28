//GuidAttribute on interface level

namespace Hafner.Compatibility.CompileTest.CS.GuidAttribute;

using System.Runtime.InteropServices;

[Guid("74EF5210-4624-4E3C-88F3-2B2E4A2CE3D0")]
public interface IInterface1 {

    string Name { get; }

}
