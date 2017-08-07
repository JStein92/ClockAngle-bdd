using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ClockAngle.Models;
using System;

namespace ClockAngle.Tests
{
  [TestClass]
  public class ClockAngleTest
  {
    [TestMethod]
    public void ClockAngle_GetHourHandDegrees_Int ()
    {
      //Arrange
      ClockAngleFinder testAngle = new ClockAngleFinder(1,0);
      int expected = 30;
      //Act
      int actual = testAngle.ReturnDegrees();
      //Assert
      Assert.AreEqual(expected,actual);
    }
    [TestMethod]
    public void ClockAngle_GetDegreeDifference_Int ()
    {
      //Arrange
      ClockAngleFinder testAngle = new ClockAngleFinder(12,15);
      int expected = 90;
      //Act
      int actual = testAngle.ReturnDegrees();
      //Assert
      Assert.AreEqual(expected,actual);
    }
  }
}
