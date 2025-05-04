namespace Hafner.Compatibility.CompileTest.CS.DynamicallyAccessedMembersAttribute;

using System;
using System.Diagnostics.CodeAnalysis;

public static class TestClass {

    [RequiresUnreferencedCode("This is just a compile test.")]
    public static void MethodThatDoesNotSupportTrimming() {
        throw new NotImplementedException();
    }

    public static void Method1() {
        Method2<DateTime>();
    }

    public static void Method2<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] T>() {
        Type t = typeof(T);
        Method3(t);
    }

    public static void Method3([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] Type type) {
        _ = type; //Do something with it
    }

    [DynamicDependency(nameof(Method3))]
    public static void SomeMethod() {
    }

}
