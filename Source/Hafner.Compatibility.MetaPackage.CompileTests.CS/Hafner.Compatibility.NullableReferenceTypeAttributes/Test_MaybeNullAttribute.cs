#pragma warning disable CA1510

namespace Hafner.Compatibility.CompileTest.CS.NullableReferenceTypeAttributes;

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

public static class Test_MaybeNullAttribute {

    /// <summary>
    /// Forces the return value to be declared as '<c>object?</c>' if the given collection is of a reference type.
    /// </summary>
    /// <param name="numbers">An argument that should not be <see langword="null"/>.</param>
    [SuppressMessage("Style", "IDE0046:Convert to conditional expression", Justification = "Would make the code messier!")]
    public static object? FindAnswerToEverything(IEnumerable<object> numbers) {
        if (numbers is null) throw new ArgumentNullException(nameof(numbers));
        return numbers.Find(e => e == ((object)42));
    }

    /// <summary>
    /// Returns the first element that matches the given predicate or the default value if not found. As we do like to return 0 and not null in case
    /// of a collection of integers (for whatever reason), we declare the return value as <c>'T'</c> and not as <c>'T?'</c> but decorate it with 
    /// attribute '<see cref="MaybeNullAttribute">MaybeNull</see>'.
    /// </summary>
    /// <typeparam name="T">The element type.</typeparam>
    /// <param name="sequence">The collection to be searched.</param>
    /// <param name="predicate">The condition when to return the first matching element.</param>
    /// <returns>The according element or the default value if not found.</returns>
    /// <exception cref="ArgumentNullException">An <see cref="ArgumentNullException"/> is thrown if either of the arguments is <see langword="null"/>.</exception>
    [return: MaybeNull]
    public static T Find<T>(this IEnumerable<T> sequence, Func<T, bool> predicate) {
        if (sequence is null) throw new ArgumentNullException(nameof(sequence));
        if (predicate is null) throw new ArgumentNullException(nameof(predicate));
        foreach (T e in sequence) {
            if (predicate(e)) return e;
        }
        return default;
    }

}
