using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using app = ConsoleApp9V.ConsoleApp9V;

namespace ConsoleApp9VTest
{


    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        //Тест проверки, что С != 0 (не будет допущено делание на ноль)
        public void CheckCTest() 
        {
            //Arrage
            double validN = 1;
            double noValidN = 0;
            //Act and Assert
            Assert.IsTrue(app.CheckC(validN));
            Assert.IsFalse(app.CheckC(noValidN));
        }

        [TestMethod]
        //Тест проверки, что X - C != 0 (не будет допущено деление на ноль)
        public void CheckXCTest() 
        {
            //Arrage
            double validX = 10;
            double validC = 1;
            double notValid = 10;
            //Act and Assert
            Assert.IsTrue(app.CheckXC(validX, validC));
            Assert.IsFalse(app.CheckXC(notValid, notValid));
        }

        [TestMethod]
        //Тест вычисления функции, валидные данные, подходят для 1го случая
        public void FunctionTest_ValidNumbers_Case1() {
            //Arrage
            double a = -10;
            double b = 1;
            double c = 1;
            double x = 2;
            double f = a * Math.Pow(x,2) + b * Math.Pow(x, 2);
            //Act and Assert
            Assert.AreEqual(app.Function(a, b, c, x).Item1, f);
        }

        [TestMethod]
        //Тест вычисления функции, валидные данные, подходят для 2го случая
        public void FunctionTest_ValidNumbers_Case2()
        {
            //Arrage
            double a = 10;
            double b = 1;
            double c = 1;
            double x = 0;
            double f = x - a / (x - c);
            //Act and Assert
            Assert.AreEqual(app.Function(a, b, c, x).Item1, f);
        }

        [TestMethod]
        //Тест вычисления функции, валидные данные, подхадят для 3го случая
        public void FunctionTest_ValidNumbers_Case3()
        {
            //Arrage
            double a = 0;
            double b = 1;
            double c = 1;
            double x = 5;
            double f = 1 + x / c;
            //Act and Assert
            Assert.AreEqual(app.Function(a, b, c, x).Item1, f);
        }

        [TestMethod]
        //Тест вычисления функции, невалидные данные, подходят для 3го случая, но математически рассчитать невозможно
        public void FunctionTest_InvalidNumbers_InvalidCase()
        {
            //Arrage
            double a = 0;
            double b = 1;
            double c = 0;
            double x = 5;
            //Act and Assert
            Assert.IsFalse(app.Function(a, b, c, x).Item2);
        }
    }
}