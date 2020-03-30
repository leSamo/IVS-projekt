using MathComponentsNS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTest
{
    [TestClass]
    public class BasicMathTests
    {
        [TestMethod]
        public void TestAddition()
        {
            // no rules for addition
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

            (errBool, result) = NewMath.Add(0.58647m, 5.789524114m);
            Assert.AreEqual(6.375994114m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(-1115475465, 1115475465);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(5687412.85m, -85456297);
            Assert.AreEqual(-79768884.15m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(0.2554157752m, 5.7458936245m);
            Assert.AreEqual(6.0013093997m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(123456789.123456789m, 987654321.987654321m);
            Assert.AreEqual(1111111111.11111111m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(-5555555555, -0.5555555555m);
            Assert.AreEqual(-5555555555.5555555555m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Add(50, 1000000000);
            Assert.AreEqual(1000000050, result);
            Assert.IsFalse(errBool);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            // no rules for subtraction
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

            (errBool, result) = NewMath.Subtract(0.58647m, 5.789524114m);
            Assert.AreEqual(-5.203054114m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(1115475465, 1115475465);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(5687412.85m, 85456297);
            Assert.AreEqual(-79768884.15m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(9992879524, -999514265);
            Assert.AreEqual(10992393789m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(999652145.2m, -99912.45621321546543m);
            Assert.AreEqual(999752057.65621321546543m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Subtract(0m, -999888777.666555444333222111m);
            Assert.AreEqual(999888777.666555444333222111m, result);
            Assert.IsFalse(errBool);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            //no rules for multiplication
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

            (errBool, result) = NewMath.Multiply(423135487211, 4771231);
            Assert.AreEqual(2018877153781226741, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(0.5125479645m, 5.4521m);
            Assert.AreEqual(2.79446275725045m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(10, -0.5m);
            Assert.AreEqual(-5, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(-562012454, -0.000005m);
            Assert.AreEqual(2810.06227m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Multiply(12345.54321m, 1);
            Assert.AreEqual(12345.54321m, result);
            Assert.IsFalse(errBool);
        }

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

            (errBool, result) = NewMath.Divide(11659.33584m, 0.25416m);
            Assert.AreEqual(45874, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(20.00m, 5.00m);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(-2060309849.5m, -4517);
            Assert.AreEqual(456123.5m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Divide(6.25m, 0.05m);
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
        }

        [TestMethod]
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
            Assert.AreEqual(0.000244140625m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(2.00m, 2.00m);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate((decimal)Math.E, 0);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(1234847151.151884485m, 0);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(0.5m, 5);
            Assert.AreEqual(0.03125m, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Exponentiate(0.5m, -10);
            Assert.AreEqual(1024, result);
            Assert.IsFalse(errBool);

            // System overflow exception
            // (errBool, result) = NewMath.Exponentiate(-8, -0.4m);
            // Assert.AreEqual(0, result);
            // Assert.IsFalse(errBool);

            //test undefined option
            (errBool, result) = NewMath.Exponentiate(0, 0);
            Assert.IsTrue(errBool);
        }

        [TestMethod]
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

            (errBool, result) = NewMath.Root(0.1m, 10);
            Assert.AreEqual(10000000000, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(6, 107918163081);
            Assert.AreEqual(69, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Root(0.5m, 125865);
            Assert.AreEqual(15841998225, result);
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
        }

        [TestMethod]
        public void TestLogarithm()
        {
            // rules: base positive and different from 1; argument positive
            MathComponents NewMath = new MathComponents();

            // tests to check Logarithm functionality
            (bool errBool, decimal result) = NewMath.Logarithm(10, 10);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(5, 25);
            Assert.AreEqual(2, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm((decimal)Math.E, (decimal)Math.E);
            Assert.AreEqual(1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(25, 390625);
            Assert.AreEqual(4, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(6.00m, 216.000m);
            Assert.AreEqual(3, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(5666257, 1);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(5512476855.125485m, 1);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Logarithm(0.5m, 0.0009765625m);
            Assert.AreEqual(10, result);
            Assert.IsFalse(errBool);

            // test undefined values
            (errBool, result) = NewMath.Logarithm(1, 4585.2555m);
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
        public void TestSin()
        {
            decimal var1 = (decimal)(Math.Round(Math.Sqrt(2) / 2 * 1e10d) / 1e10d);
            decimal var2 = (decimal)(Math.Round(Math.Sqrt(3) / 2 * 1e10d) / 1e10d);

            // no rules for sinus
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
        public void TestCos()
        {
            decimal var1 = (decimal)(Math.Round(Math.Sqrt(2) / 2 * 1e10d) / 1e10d);
            decimal var2 = (decimal)(Math.Round(Math.Sqrt(3) / 2 * 1e10d) / 1e10d);

            // no rules for cosinus
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
            Assert.AreEqual(-0.5m, result);
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
        public void TestTan()
        {
            decimal var1 = (decimal)(Math.Round(Math.Sqrt(3) * 1e10d) / 1e10d);
            decimal var2 = (decimal)(Math.Round(Math.Sqrt(3) / 3 * 1e10d) / 1e10d);

            // rules: tangens is undefined in ( PI / 2 + k * PI )
            MathComponents NewMath = new MathComponents();

            // tests toi check Tangens functionality
            (bool errBool, decimal result) = NewMath.Tan(5 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan(2.25m * (decimal)Math.PI);
            Assert.AreEqual(1, result);
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
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan(6651 * (decimal)Math.PI);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Tan((526 / 8m) * (decimal)Math.PI);
            Assert.AreEqual(-1, result);
            Assert.IsFalse(errBool);

            //test undefined values
            /*
            (errBool, result) = NewMath.Tan(0.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Tan(-5.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);

            (errBool, result) = NewMath.Tan(1245.5m * (decimal)Math.PI);          
            Assert.IsTrue(errBool);
            */
        }

        [TestMethod]
        public void TestArcsin()
        {
            // rules: domain : -1 <= x <= 1 ; range : -PI/2 <= y <= PI/2
            MathComponents NewMath = new MathComponents();

            // tests to check Arcsin functionality
            (bool errBool, decimal result) = NewMath.Arcsin(-1);
            Assert.AreEqual((-Math.PI / 2), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)-Math.Sqrt(3) / 2);
            Assert.AreEqual((-Math.PI / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)-Math.Sqrt(2) / 2);
            Assert.AreEqual((-Math.PI / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(-0.5m);
            Assert.AreEqual((-Math.PI / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(0.5m);
            Assert.AreEqual((Math.PI / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)Math.Sqrt(2) / 2);
            Assert.AreEqual((Math.PI / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin((decimal)Math.Sqrt(3) / 2);
            Assert.AreEqual((Math.PI / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arcsin(1);
            Assert.AreEqual((Math.PI / 2), result);
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
        public void TestArccos()
        {
            // rules: domain : -1 <= x <= 1 ; range : 0 <= y <= PI
            MathComponents NewMath = new MathComponents();

            // tests to check Arccos functionality
            (bool errBool, decimal result) = NewMath.Arccos(-1);
            Assert.AreEqual((Math.PI), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)-Math.Sqrt(3) / 2);
            Assert.AreEqual(( (5 * Math.PI) / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)-Math.Sqrt(2) / 2);
            Assert.AreEqual(((3 * Math.PI) / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(-0.5m);
            Assert.AreEqual(((2 * Math.PI) / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(0);
            Assert.AreEqual((Math.PI / 2), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(0.5m);
            Assert.AreEqual((Math.PI / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)Math.Sqrt(2) / 2);
            Assert.AreEqual((Math.PI / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos((decimal)Math.Sqrt(3) / 2);
            Assert.AreEqual((Math.PI / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arccos(1);
            Assert.AreEqual(0, result);
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
        public void TestArctan()
        {
            // rules: domain : all real numbers ; range : -PI/2 <= y <= PI/2
            MathComponents NewMath = new MathComponents();

            // tests to check Arctan functionality
            (bool errBool, decimal result) = NewMath.Arctan((decimal)-Math.Sqrt(3));
            Assert.AreEqual((-Math.PI / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(-1);
            Assert.AreEqual((-Math.PI / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal)-Math.Sqrt(3) / 3);
            Assert.AreEqual((-Math.PI / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(0);
            Assert.AreEqual(0, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal)Math.Sqrt(3) / 3);
            Assert.AreEqual((Math.PI / 6), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan(1);
            Assert.AreEqual((Math.PI / 4), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal) Math.Sqrt(3));
            Assert.AreEqual((Math.PI / 3), result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Arctan((decimal) Math.Sqrt(3) / 2);
            Assert.AreEqual((Math.PI / 6), result);
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

            (errBool, result) = NewMath.Factorial(17);
            Assert.AreEqual(355687428096000, result);
            Assert.IsFalse(errBool);

            (errBool, result) = NewMath.Factorial(10);
            Assert.AreEqual(3628800, result);
            Assert.IsFalse(errBool);

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