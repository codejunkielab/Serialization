using CodeJunkie.Serialization;
using Moq;
using Shouldly;
using System;
using Xunit;

namespace CodeJunkie.Serialization.Tests {
  public class SerializationUtilitiesTests {
    [Fact]
    public void IsEquivalent_ShouldReturnTrue_ForSameReference() {
      // Arrange
      var obj = new object();

      // Act
      var result = SerializationUtilities.IsEquivalent(obj, obj);

      // Assert
      result.ShouldBeTrue();
    }

    [Fact]
    public void IsEquivalent_ShouldReturnTrue_ForEqualValues() {
      // Arrange
      var obj1 = "test";
      var obj2 = "test";

      // Act
      var result = SerializationUtilities.IsEquivalent(obj1, obj2);

      // Assert
      result.ShouldBeTrue();
    }

    [Fact]
    public void IsEquivalent_ShouldReturnFalse_ForDifferentValues() {
      // Arrange
      var obj1 = "test1";
      var obj2 = "test2";

      // Act
      var result = SerializationUtilities.IsEquivalent(obj1, obj2);

      // Assert
      result.ShouldBeFalse();
    }

    [Fact]
    public void IsEquivalent_ShouldReturnTrue_WhenBothAreNull() {
      // Act
      var result = SerializationUtilities.IsEquivalent(null, null);

      // Assert
      result.ShouldBeTrue();
    }

    [Fact]
    public void IsEquivalent_ShouldReturnFalse_WhenOneIsNull() {
      // Arrange
      var obj = new object();

      // Act
      var result1 = SerializationUtilities.IsEquivalent(obj, null);
      var result2 = SerializationUtilities.IsEquivalent(null, obj);

      // Assert
      result1.ShouldBeFalse();
      result2.ShouldBeFalse();
    }
  }
}

