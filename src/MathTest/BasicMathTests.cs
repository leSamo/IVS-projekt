/**
 * @file BasicMathTests.cs
 * @brief File of tests for checking if calculator calutates right
 * @author Michal Findra
 */

using MathComponentsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTest
{
    [TestClass]
    public class BasicMathTests
    {

        /**
         * @brief Function to round-off the number 
         */
        public static decimal RoundOff(decimal value)
        {           
            int wholeDigits = (int)Math.Floor(1 + Math.Log10((double)Math.Abs(value)));            
            if (value == 0)
            {
                return (0);
            }
            else if (Math.Abs(value) < 10)
            {
                decimal result = (decimal)(Math.Truncate((double)value * 10e7) / 10e7);
                return (result);
            }
            else
            {
                decimal result = (decimal)(Math.Truncate((double)value * Math.Pow(10, 9 - wholeDigits)) / Math.Pow(10, 9 - wholeDigits));
                return (result);
            }

        }

        [TestMethod]
        /**
         * @brief Tests to check addition functionality
         * @brief  testing if length is max 9 significant digits
         */
        public void TestAddition()
        {
            // no mathematical rules for addition
            MathComponents NewMath = new MathComponents();

            // tests to check addition functionality
            (bool errBool, decimal result) = NewMath.Add(1, 1);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(0, 0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(1.00m, 1.00m);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(-1, -1);
            Assert.AreEqual(-2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(0.7m, 0.3m);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(7.65m, -2.65m);
            Assert.AreEqual(5, result);
            Assert.IsFalse(errBool);

            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Add(0.58647m, 5.78952411m);
            Assert.AreEqual(RoundOff(6.37599411m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(-111547546, 111547546);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(5687412.85m, -85456297);
            Assert.AreEqual(RoundOff(-79768884.15m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(0.25541577m, 5.74589362m);
            Assert.AreEqual(RoundOff(6.00130939m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(123456789, 0.98765432m);
            Assert.AreEqual(RoundOff(123456789.98765432m), result);
            Assert.IsFalse(errBool);

            // test error handling
            (errBool, result) = NewMath.Add(-555555555, -555555555);
            //Assert.AreEqual(RoundOff(-1111111110), result);
            Assert.IsTrue(errBool);
            
            (errBool, result) = NewMath.Add(900000000, 900000000);
            //Assert.AreEqual(RoundOff(1800000000), result);
            Assert.IsTrue(errBool);                                   
        }

        [TestMethod]
        /**
         * @brief Tests to check subtracion functionality
         *  @brief testing if length is max 9 significant digits
         */
        public void TestSubtraction()
        {
            // no mathematical rules for subtraction
            MathComponents NewMath = new MathComponents();

            // tests to check subtracion functionality
            (bool errBool, decimal result) = NewMath.Subtract(1, 1);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(0, 0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(1, 1);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(12, -12);
            Assert.AreEqual(24, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(5, 0.55m);
            Assert.AreEqual(4.45m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(-3.00m, -3.00m);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(5.47m, 2.47m);
            Assert.AreEqual(3, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(-3.25478m, -0.25478m);
            Assert.AreEqual(-3, result);
            Assert.IsFalse(errBool);

            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Subtract(0.58647m, 5.78952411m);
            Assert.AreEqual(RoundOff(-5.20305411m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(1115475465, 1115475465);
            Assert.AreEqual(RoundOff(0), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(5687412.85m, 85456297);
            Assert.AreEqual(RoundOff(-79768884.15m), result);
            Assert.IsFalse(errBool);
            
            (errBool, result) = NewMath.Subtract(9652145.2m, -9912.4567m);
            Assert.AreEqual(RoundOff(9662057.6567m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(0.99999999m, -0.99999999m);
            Assert.AreEqual(RoundOff(1.99999998m), result);
            Assert.IsFalse(errBool);
            
            // test error handling
            (errBool, result) = NewMath.Subtract(999287952, -999514265);
            //Assert.AreEqual(RoundOff(1998802217), result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Subtract(900000000, -900000000);
            //Assert.AreEqual(RoundOff(1800000000), result);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check multiplication functionality
         * @brief  testing if length is max 9 significant digits
         */
        public void TestMultiplication()
        {
            //no mathematical rules for multiplication
            MathComponents NewMath = new MathComponents();

            // tests to check multiplication functionality
            (bool errBool, decimal result) = NewMath.Multiply(1, 1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(0, 0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(1, 1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(125487, 0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(0, 123547.254m);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(5.00m, 4.00m);
            Assert.AreEqual(20, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(-6, -5);
            Assert.AreEqual(30, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(7, -6);
            Assert.AreEqual(-42, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(-8, 9);
            Assert.AreEqual(-72, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(10, -0.5m);
            Assert.AreEqual(-5, result);
            Assert.IsFalse(errBool);

            // test length of returning value (max 9 significant digits)            
            (errBool, result) = NewMath.Multiply(0.5125479645m, 5.4521m);
            Assert.AreEqual(RoundOff(2.79446275725045m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(-999454, -9.000005m);
            Assert.AreEqual(RoundOff(8995090.99727m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(0.55555555m, 0.9999999m);
            Assert.AreEqual(RoundOff(0.55555549m), result);
            Assert.IsFalse(errBool);

            // test error handling
            (errBool, result) = NewMath.Multiply(423135487, 47712318);
            //Assert.AreEqual(RoundOff(20188774912828866‬), result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Multiply(54545454, 808.80855m);
            //Assert.AreEqual(RoundOff(44116829558.8317), result);
            Assert.IsTrue(errBool);
        }

        /**
         * @brief Tests to check division functionality
         * @brief division by zero is not possible
         * @brief testing if length is max 9 significant digits
         */
        [TestMethod]
        public void TestDivision()
        {
            //rules: cannnot divide by 0
            MathComponents NewMath = new MathComponents();

            // tests to check division functionality
            (bool errBool, decimal result) = NewMath.Divide(1, 1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(10, 5);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(10, -2.5m);
            Assert.AreEqual(-4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(-18, -2);
            Assert.AreEqual(9, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(0, 452871);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(11656.5834m, 0.2541m);
            Assert.AreEqual(45874, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(20.00m, 5.00m);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(-2060309849.5m, -4517);
            Assert.AreEqual(456123.5m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(-6.25m, -0.05m);
            Assert.AreEqual(125, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(0.008m, 0.008m);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            //test division by 0
            (errBool, result) = NewMath.Divide(7744654.1254m, 0);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Divide(-451255.126359m, 0);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Divide(0, 0);
            Assert.IsTrue(errBool);
            
            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Divide(555555.55m, 5.222222m);
            Assert.AreEqual(RoundOff(106382.9821865098m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(3216546, 123.456m);
            Assert.AreEqual(RoundOff(26054.1893468118195m), result);
            Assert.IsFalse(errBool);

            // test error handling
            (errBool, result) = NewMath.Divide(999999999, 0.5m);
            //Assert.AreEqual(RoundOff(1999999998m), result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Divide(898989898, 0.005m);
            //Assert.AreEqual(RoundOff(179797979600), result);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check exponential functionality
         * @brief  0^0 is undefined
         * @brief  testing if length is max 9 significant digits
         */
        public void TestExponentiation()
        {
            // rules: 0^0 is undefined
            MathComponents NewMath = new MathComponents();

            // tests to check exponential functionality
            (bool errBool, decimal result) = NewMath.Exponentiate(1, 1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(2, 5);
            Assert.AreEqual(32, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(4, -2);
            Assert.AreEqual(0.0625m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(-5, 3);
            Assert.AreEqual(-125, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(-8, -4);
            Assert.AreEqual(0.00024414m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(2.00m, 2.00m);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate((decimal)Math.E, 0);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(123456.151m, 0);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(0.5m, 5);
            Assert.AreEqual(0.03125m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(0.5m, -10);
            Assert.AreEqual(1024, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(12, 8);
            Assert.AreEqual(429981696, result);
            Assert.IsFalse(errBool);

            // test undefined option
            (errBool, result) = NewMath.Exponentiate(0, 0);
            Assert.IsTrue(errBool);

            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Exponentiate(2, 0.3m);
            Assert.AreEqual(RoundOff(1.23114441334491628449m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(0.5m, 10);
            Assert.AreEqual(RoundOff(0.00097656m), result);
            Assert.IsFalse(errBool);

            // test error handling
            (errBool, result) = NewMath.Exponentiate(15, 12);
            //Assert.AreEqual(RoundOff(129746337890625), result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Exponentiate(8, 12);
            //Assert.AreEqual(RoundOff(68719476736‬), result);
            Assert.IsTrue(errBool); 
        }

        [TestMethod]
        /**
         * @brief Tests to check root functionality
         * @brief  root only from positive numbers
         * @brief  testing if length is max 9 significant digits
         */
        public void TestRoot()
        {
            // rules: root only from positive numbers
            MathComponents NewMath = new MathComponents();

            // tests to check root functionality
            (bool errBool, decimal result) = NewMath.Root(1, 1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(2, 25);
            Assert.AreEqual(5, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(3.00m, 125.00m);
            Assert.AreEqual(5, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(0.25m, 30);
            Assert.AreEqual(810000, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(-4, 16);
            Assert.AreEqual(0.5m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(-0.5m, 8);
            Assert.AreEqual(0.015625m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(0.5m, 10);
            Assert.AreEqual(100, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(4, 22667121);
            Assert.AreEqual(69, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(0.5m, 12586);
            Assert.AreEqual(158407396, result);
            Assert.IsFalse(errBool);

            // test undefined values
            (errBool, result) = NewMath.Root(0, 752041.44221m);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Root(4, -125);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Root(-3, -12.4m);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Root(2.4m, -23.25874m);
            Assert.IsTrue(errBool);

            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Root(2, 0.3m);
            Assert.AreEqual(RoundOff(0.54772255m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(3, 5);
            Assert.AreEqual(RoundOff(1.7099759466766m), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(0.3m, 65);
            Assert.AreEqual(RoundOff(1104191.8114525m), result);
            Assert.IsFalse(errBool);

            // test error handling
            (errBool, result) = NewMath.Root(0.5m, 50000);
            //Assert.AreEqual(RoundOff(2500000000), result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Root(0.2m, 600);
            //Assert.AreEqual(RoundOff(77760000000000‬), result);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Logarithm functionality
         * @brief  base must be positive and different from 1
         * @brief argument must be positive
         * @brief testing if length is max 9 significant digits
         */
        public void TestLogarithm()
        {
            // rules: base positive and different from 1; argument positive
            MathComponents NewMath = new MathComponents();

            // tests to check Logarithm functionality
            (bool errBool, decimal result) = NewMath.Logarithm(10, 10);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(25, 5);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm((decimal)Math.E, (decimal)Math.E);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(390625, 25);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(216m, 6.00m);
            Assert.AreEqual(3, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(0.00390625m, 0.5m);
            Assert.AreEqual(8, result);
            Assert.IsFalse(errBool);

            // test length of returning value (max 9 significant digits)
            (errBool, result) = NewMath.Logarithm(8, (decimal)Math.E);
            Assert.AreEqual(RoundOff(2.079441541679m), result);
            Assert.IsFalse(errBool);

            // test undefined values
            (errBool, result) = NewMath.Logarithm(4585.2555m, 1m);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Logarithm(-0.5874m, 14);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Logarithm(-3, 15);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Logarithm(5, -1);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Logarithm(13, -45621155.4545154m);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Logarithm(-125.12m, -457.25m);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Sin functionality
         * @brief tests are in RAD
         */
        public void TestSin()
        {
            decimal var1 = RoundOff((decimal)((Math.Sqrt(2) / 2 * 1e10d) / 1e10d));
            decimal var2 = RoundOff((decimal)((Math.Sqrt(3) / 2 * 1e10d) / 1e10d));

            // no mathematical rules for sinus
            // tests are in RAD
            MathComponents NewMath = new MathComponents();

            // tests to check Sin functionality
            (bool errBool, decimal result) = NewMath.Sin(1 * (decimal)Math.PI);            
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);            

            (errBool, result) = NewMath.Sin(2 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(0.5m * (decimal)Math.PI);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(-1 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(-5 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(-0.5m * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(-0.75m * (decimal)Math.PI);
            Assert.AreEqual(-var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(2.75m * (decimal)Math.PI);
            Assert.AreEqual(var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin((2 / 3m) * (decimal)Math.PI);
            Assert.AreEqual(var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(54 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin((121 / 3m) * (decimal)Math.PI);
            Assert.AreEqual(var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Sin(512.5m * (decimal)Math.PI);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Cos functionality
         */
        public void TestCos()
        {
            decimal var1 = RoundOff((decimal)((Math.Sqrt(2) / 2 * 1e10d) / 1e10d));
            decimal var2 = RoundOff((decimal)((Math.Sqrt(3) / 2 * 1e10d) / 1e10d));                 

            // no mathematical rules for cosinus
            MathComponents NewMath = new MathComponents();

            // tests to check Cos functionality
            (bool errBool, decimal result) = NewMath.Cos(1 * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos(2 * (decimal)Math.PI);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos(0.5m * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((2/3m) * (decimal)Math.PI);
            Assert.AreEqual(-0.5m, Decimal.Round(result,7));
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((6/3m) * (decimal)Math.PI);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((9/3m) * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((1/4m) * (decimal)Math.PI);
            Assert.AreEqual(var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((-13/4m) * (decimal)Math.PI);
            Assert.AreEqual(-var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((25/6m) * (decimal)Math.PI);
            Assert.AreEqual(var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos((31/6m) * (decimal)Math.PI);
            Assert.AreEqual(-var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos(2547.5m * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos(333333 * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Cos( (9/4m) * (decimal)Math.PI);
            Assert.AreEqual(var1, result);
            Assert.IsFalse(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Tangens functionality
         * @brief tangens is undefined in ( PI / 2 + k * PI )
         */
        public void TestTan()
        {
            decimal var1 = RoundOff((decimal)((Math.Sqrt(3) * 1e10d) / 1e10d));
            decimal var2 = RoundOff((decimal)(Math.Round(Math.Sqrt(3) / 3 * 1e10d) / 1e10d));

            // rules: tangens is undefined in ( PI / 2 + k * PI )
            MathComponents NewMath = new MathComponents();

            // tests to check Tangens functionality
            (bool errBool, decimal result) = NewMath.Tan(5 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan(2.25m * (decimal)Math.PI);
            Assert.AreEqual(1, Decimal.Round(result,7));
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan(4.75m * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((2 / 3m) * (decimal)Math.PI);
            Assert.AreEqual(-var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((-26 / 3m) * (decimal)Math.PI);
            Assert.AreEqual(var1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((13 / 6m) * (decimal)Math.PI);
            Assert.AreEqual(var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((-85 / 6m) * (decimal)Math.PI);
            Assert.AreEqual(-var2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((-13 / 4m) * (decimal)Math.PI);
            Assert.AreEqual(-1, Decimal.Round(result,7));
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan(6651 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((526 / 8m) * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            //test undefined values            
            (errBool, result) = NewMath.Tan(0.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Tan(-5.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Tan(1245.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);            
        }

        [TestMethod]
        /**
         * @brief Tests to chcek Arcsin functionality
         * @brief domain is -1 <= x <= 1 
         * @brief range is -PI/2 <= y <= PI/2
         */
        public void TestArcsin()
        {
            // rules: domain : -1 <= x <= 1 ; range : -PI/2 <= y <= PI/2
            MathComponents NewMath = new MathComponents();

            // tests to check Arcsin functionality
            (bool errBool, decimal result) = NewMath.Arcsin(-1);
            Assert.AreEqual(-1.57079632m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)-Math.Sqrt(3) / 2);
            Assert.AreEqual(-1.04719755m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)-Math.Sqrt(2) / 2);
            Assert.AreEqual(-0.78539816m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(-0.5m);
            Assert.AreEqual(-0.52359877m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(0.5m);
            Assert.AreEqual(0.52359877m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)Math.Sqrt(2) / 2);
            Assert.AreEqual(0.78539816m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)Math.Sqrt(3) / 2);
            Assert.AreEqual(1.04719755m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(1);
            Assert.AreEqual(1.57079632m, result);
            Assert.IsFalse(errBool);

            //test undefined values
            (errBool, result) = NewMath.Arcsin(2);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arcsin(-5);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arcsin(-5.5m * (decimal)Math.PI);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arcsin(1245.5m * (decimal)Math.PI);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Arccos functionality
         * @brief  domain is -1 <= x <= 1 
         * @brief range is 0 <= y <= PI
         */
        public void TestArccos()
        {
            // rules: domain : -1 <= x <= 1 ; range : 0 <= y <= PI
            MathComponents NewMath = new MathComponents();

            // tests to check Arccos functionality
            (bool errBool, decimal result) = NewMath.Arccos(-1);
            Assert.AreEqual(3.14159265m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)-Math.Sqrt(3) / 2);
            Assert.AreEqual(2.61799387m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)-Math.Sqrt(2) / 2);
            Assert.AreEqual(2.35619449m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(-0.5m);
            Assert.AreEqual(2.09439510m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(0);
            Assert.AreEqual(1.57079632m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(0.5m);
            Assert.AreEqual(1.04719755m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)Math.Sqrt(2) / 2);
            Assert.AreEqual(0.78539816m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)Math.Sqrt(3) / 2);
            Assert.AreEqual(0.52359877m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(1);
            Assert.AreEqual(0m, result);
            Assert.IsFalse(errBool);

            //test undefined values
            (errBool, result) = NewMath.Arccos(2);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arccos(-5);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arccos(-5.5m * (decimal)Math.PI);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Arccos(1245.5m * (decimal)Math.PI);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
        /**
         * @brief Tests to check Arctan functionality
         * @brief  domain are all real numbers 
         * @brief  range is -PI/2 <= y <= PI/2
         */
        public void TestArctan()
        {
            // rules: domain : all real numbers ; range : -PI/2 <= y <= PI/2
            MathComponents NewMath = new MathComponents();

            // tests to check Arctan functionality
            (bool errBool, decimal result) = NewMath.Arctan((decimal)-Math.Sqrt(3));
            Assert.AreEqual(RoundOff((decimal)(-Math.PI / 3)), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(-1);
            Assert.AreEqual(-0.78539816m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal)-Math.Sqrt(3) / 3);
            Assert.AreEqual(-0.52359877m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal)Math.Sqrt(3) / 3);
            Assert.AreEqual(0.52359877m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(1);
            Assert.AreEqual(0.78539816m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal) Math.Sqrt(3));
            Assert.AreEqual(1.04719755m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(5);
            Assert.IsTrue((decimal)(Math.PI / 2 ) > result);
            Assert.IsTrue((decimal)(-Math.PI / 2) < result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(15646);
            Assert.IsTrue((decimal)(Math.PI / 2) > result);
            Assert.IsTrue((decimal)(-Math.PI / 2) < result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(-6);
            Assert.IsTrue((decimal)(Math.PI / 2) > result);
            Assert.IsTrue((decimal)(-Math.PI / 2) < result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(-25415);
            Assert.IsTrue((decimal)(Math.PI / 2) > result);
            Assert.IsTrue((decimal)(-Math.PI / 2) < result);
            Assert.IsFalse(errBool);

        }

        [TestMethod]
        /**
         * @brief Tests to check Factorial functionality
         * @brief  domain is positive integer
         */
        public void TestFactorial()
        {
            // rules: domain: positive integer
            MathComponents NewMath = new MathComponents();

            // tests to check Factorial functionality
            (bool errBool, decimal result) = NewMath.Factorial(0);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(1);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(2);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(3);
            Assert.AreEqual(6, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(5);
            Assert.AreEqual(120, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(8);
            Assert.AreEqual(40320, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(11);
            Assert.AreEqual(39916800, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(12);
            Assert.AreEqual(479001600, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(13);
            //Assert.AreEqual(6227020800, result);
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Factorial(17);
            //Assert.AreEqual(355687428096000, result);
            Assert.IsTrue(errBool);

            // test indefined values
            (errBool, result) = NewMath.Factorial(-3);         
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Factorial(-3.547m);         
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Factorial(53.7412m);         
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Factorial(-1);         
            Assert.IsTrue(errBool);

        }

        [TestMethod]
        /**
         * @brief Tests to check Factorial functionality
         * @brief  range is 0 <= x <= 1
         */
        public void TestRandom()
        {
            // rules: range: 0 <= x <= 1
            MathComponents NewMath = new MathComponents();

            // tests to check Factorial functionality
            (bool errBool, decimal result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Random();
            Assert.IsTrue(1 >= result);
            Assert.IsTrue(0 <= result);
            Assert.IsFalse(errBool);
        }
    }
}
