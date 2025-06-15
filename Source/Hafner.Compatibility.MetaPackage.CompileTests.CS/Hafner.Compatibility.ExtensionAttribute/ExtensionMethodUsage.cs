namespace Hafner.Compatibility.CompileTest.CS.ExtensionAttribute;

using System.Collections.Generic;

public sealed class ExtensionMethodUsage {

    public static void DoSomething() {
        List<string> list = ["a", "b", "c"];
        bool hasElements = list.HasElements();
        //Do more...
        _ = hasElements;
    }

}
