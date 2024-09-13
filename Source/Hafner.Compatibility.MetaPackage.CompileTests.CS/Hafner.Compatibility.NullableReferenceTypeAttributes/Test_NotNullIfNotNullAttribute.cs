#pragma warning disable CA1510

namespace Hafner.Compatibility.CodeAnalysisAttributes.CompileTests;

using System.Diagnostics.CodeAnalysis;

public static class Test_NotNullIfNotNullAttribute {

    /// <summary>
    /// Line '<c>EntityA entity = record.ToEntityA();</c>' would fail with a 'CS8600: Converting null literal or possible null value to non-nullable type.'
    /// if function <see cref="RecordAExtensions.ToEntityA(RecordA?)"/> would not be decorated with a <see cref="NotNullIfNotNullAttribute">NotNullIfNotNull</see> attribute.
    /// </summary>
    public static void DoSomething() {
        RecordA record = new RecordA();
        EntityA entity = record.ToEntityA();
    }

}

public class RecordA {

    //Containing some properties

}

public class EntityA {

    //Containing some properties

}

internal static class RecordAExtensions {

    /// <summary>
    /// Defines that the result is not <see langword="null"/> if the input is not <see langword="null"/>.
    /// </summary>
    /// <param name="record">The record to be converted.</param>
    /// <returns>The converted entity, <see langword="null"/> if <paramref name="record"/> is <see langword="null"/>.</returns>
    [return: NotNullIfNotNull(nameof(record))]
    public static EntityA? ToEntityA(this RecordA? record) {
        if (record is null) return null;
        EntityA result = new EntityA();
        //Copy all properties
        return result;
    }

}
