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
        //���� ��������, ��� � != 0 (�� ����� �������� ������� �� ����)
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
        //���� ��������, ��� X - C != 0 (�� ����� �������� ������� �� ����)
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
        //���� ���������� �������, �������� ������, �������� ��� 1�� ������
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
        //���� ���������� �������, �������� ������, �������� ��� 2�� ������
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
        //���� ���������� �������, �������� ������, �������� ��� 3�� ������
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
        //���� ���������� �������, ���������� ������, �������� ��� 3�� ������, �� ������������� ���������� ����������
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