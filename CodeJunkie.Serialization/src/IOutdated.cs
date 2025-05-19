namespace CodeJunkie.Serialization;

using CodeJunkie.Collections;

/// <summary>
/// Defines an object that can upgrade itself after deserialization.
/// </summary>
public interface IOutdated {
/// <summary>
/// Upgrades the object to its latest version after deserialization.
/// </summary>
/// <param name="deps">Dependencies for the upgrade process.</param>
/// <returns>The upgraded object or another outdated object for further upgrades.</returns>
  object Upgrade(IReadOnlyBlackboard deps);
}
