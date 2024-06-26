﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleSolver;
using NUnit.Framework;
using System.Security.Policy;

namespace TriangleTest
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void Check_equilateral_Triangle_is_valid()
        {
            // Arrange
            int hypotenuse_side = 8;
            int opposite_side = 8;
            int adjacent_side = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(hypotenuse_side,opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an EQUILATERAL", result);
        }
        [Test]
        public void Check_isosceles_traingle_is_valid_test1()
        {
            // Arrange
            int hypotenuse_side = 8;
            int opposite_side = 8;
            int adjacent_side = 7;

            // Act
            string result = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        [Test]
        public void Check_isosceles_traingle_is_valid_test2()
        {
            // Arrange
            int hypotenuse_side = 9;
            int opposite_side = 9;
            int adjacent_side = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }
        public void Check_isosceles_traingle_is_valid_test3()
        {
            // Arrange
            int hypotenuse_side = 9;
            int opposite_side = 9;
            int adjacent_side = 8;

            // Act
            string result = Triangle.AnalyzeTriangle(hypotenuse_side, opposite_side, adjacent_side);

            // Assert
            Assert.AreEqual("The triangle is valid and is an ISOSCELES", result);
        }

    }
}
