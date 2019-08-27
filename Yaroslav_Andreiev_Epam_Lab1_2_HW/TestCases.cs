using lab1task1;
using lab1task2;
using lab1task3;
using lab1task4;
using lab1task5;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaroslav_Andreiev_Epam_Lab1_2_HW
{
    [TestFixture]
    class TestCases
    {
        Rectangle myRectangle = new Rectangle(2, 3, 3, 1);
        Rectangle_Auto_Implemented myRectangleAuto = new Rectangle_Auto_Implemented();
        Circle myCircle = new Circle();
        ComplexNumber num1 = new ComplexNumber(1, 1);
        ComplexNumber num2 = new ComplexNumber(1, 3);
        ComplexNumber result = new ComplexNumber(-2, 4);
        [TestCase]
        public void Lab1Task1Square()
        {
            Assert.AreEqual(2, myRectangle.square());
        }
        [TestCase]
        public void Lab1Task1Perimeter()
        {
            Assert.AreEqual(6, myRectangle.perimeter());
        }
        [TestCase]
        public void Lab1Task2Square()
        {
            myRectangleAuto.leftTopX = 2;
            myRectangleAuto.leftTopY = 3;
            myRectangleAuto.rightDownX = 3;
            myRectangleAuto.rightDownY = 1;
            Assert.AreEqual(2, myRectangleAuto.GetSquare);
        }
        [TestCase]
        public void Lab1Task2Perimeter()
        {
            myRectangleAuto.leftTopX = 2;
            myRectangleAuto.leftTopY = 3;
            myRectangleAuto.rightDownX = 3;
            myRectangleAuto.rightDownY = 1;
            Assert.AreEqual(6, myRectangleAuto.GetPerimeter);
        }
        [TestCase]
        public void Lab1Task3CircleGetLengthSquare()
        {
            Assert.AreEqual(12.56, myCircle.length(2));
            Assert.AreEqual(28.26, myCircle.square(3));
        }
        [TestCase]
        public void Lab1Task4StatRectangleCircle()
        {
            Assert.AreEqual(6, StatRectangle.perimeter(2, 3, 3, 1));
            Assert.AreEqual(2, StatRectangle.square(2, 3, 3, 1));
            Assert.AreEqual(12.56, StatCircle.length(2));
            Assert.AreEqual(28.26, StatCircle.square(3));
        }
        [TestCase]
        public void Lab1Task5ComplexDivisionNotNull()
        {
            Assert.NotNull(num1 / num2);
        }
        [TestCase]
        public void Lab1Task5ComplexMultipleNotNull()
        {
            Assert.NotNull(num1 * num2);
        }
    }
}
