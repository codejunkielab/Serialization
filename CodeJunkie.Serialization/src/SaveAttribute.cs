namespace CodeJunkie.Serialization;

using System;

/// <summary>
/// Marks a property for serialization.
/// </summary>
[AttributeUsage(AttributeTargets.Property)]
public class SaveAttribute : Attribute {
/// <summary>
/// The name used during serialization.
/// </summary>
  public string Id { get; }

/// <summary>
/// Initializes the attribute with a specified property name.
/// </summary>
/// <param name="id">The name used during serialization.</param>
  public SaveAttribute(string id) {
    Id = id;
  }
}
