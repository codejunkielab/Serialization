namespace CodeJunkie.Serialization;

using System.Collections.Generic;
using System.Runtime.CompilerServices;

/// <summary>Provides utility methods for serialization.</summary>
public static class SerializationUtilities {
  /// <summary>
  /// Checks if two objects are equivalent. Objects are equivalent if they reference the same instance or are equal based on the default equality comparer.
  /// </summary>
  /// <param name="a">The first object to compare.</param>
  /// <param name="b">The second object to compare.</param>
  /// <returns>True if the objects are equivalent; otherwise, false.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsEquivalent(object? a, object? b) =>
    ReferenceEquals(a, b) ||
    (a is null && b is null) ||
    (a is not null && b is not null && EqualityComparer<object>.Default.Equals(a, b));
}
