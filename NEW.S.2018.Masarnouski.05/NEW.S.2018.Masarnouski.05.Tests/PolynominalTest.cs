using NUnit.Framework;
using System;

namespace NEW.S._2018.Masarnouski._05.Tests
{
    [TestFixture]
    sealed class PolynominalTest
    {
        #region EqualsOperator
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 1d, 1d }, ExpectedResult = false)]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 1d, 1d, 1d, 1d }, ExpectedResult = false)]
        public bool PolynomialOperatorEquals_DifferetLengthPolynomialToPolynomial_ReturnFalseTests(double[] coefficientsPolynomial1, double[] coefficientsPolynomial2)
        {
            Polynomial polynomial1 = new Polynomial(coefficientsPolynomial1);
            Polynomial polynomial2 = new Polynomial(coefficientsPolynomial2);

            return polynomial1 == polynomial2;
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 0d, 1d, 2d, 3d }, ExpectedResult = true)]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 3d, 2d, 1d, 0d }, ExpectedResult = false)]
        public bool PolynomialOperator_Equals_Check_Arguments(double[] coefficientsPolynomial1, double[] coefficientsPolynomial2)
        {
            Polynomial polynomial1 = new Polynomial(coefficientsPolynomial1);
            Polynomial polynomial2 = new Polynomial(coefficientsPolynomial2);

            return polynomial1 == polynomial2;
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d })]
        public void PolynomialOperator_Equals_When_Second_Argument_is_Null_ExceptionReturned(double[] coefficients)
        {
            Polynomial polynomial1 = new Polynomial(coefficients);
            Polynomial polynomial2 = null;
            bool b;
            Assert.Throws<ArgumentNullException>(() => b = polynomial1 == polynomial2);
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d })]
        public void PolynomialOperator_Equals_When_First_Argument_is_Null_ExceptionReturned(double[] coefficients)
        {
            Polynomial polynomial1 = null;
            Polynomial polynomial2 = new Polynomial(coefficients);
            bool b;
            Assert.Throws<ArgumentNullException>(() => b = polynomial1 == polynomial2);
        }
        [Test]
        [TestCase(null, null, ExpectedResult = true)]
        public bool PolynomialOperator_Equals_NullArguments_FalseReturne(Polynomial polynomial1, Polynomial polynomial2)
        {
            return polynomial1 == polynomial2;
        }
        #endregion
        #region NotEqualOperators
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 1d, 1d }, ExpectedResult = true)]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 1d, 1d, 1d, 1d }, ExpectedResult = true)]
        public bool PolynomialOperatorNotEqual_DifferetLengthPolynomialToPolynomial_ReturnTrueTests(double[] coefficientsPolynomial1, double[] coefficientsPolynomial2)
        {
            Polynomial polynomial1 = new Polynomial(coefficientsPolynomial1);
            Polynomial polynomial2 = new Polynomial(coefficientsPolynomial2);

            return polynomial1 != polynomial2;
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 0d, 1d, 2d, 3d }, ExpectedResult = false)]
        [TestCase(new[] { 0d, 1d, 2d, 3d }, new[] { 3d, 2d, 1d, 0d }, ExpectedResult = true)]
        public bool PolynomialOperator_NotEquals_Check_Arguments(double[] coefficientsPolynomial1, double[] coefficientsPolynomial2)
        {
            Polynomial polynomial1 = new Polynomial(coefficientsPolynomial1);
            Polynomial polynomial2 = new Polynomial(coefficientsPolynomial2);

            return polynomial1 != polynomial2;
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d })]
        public void PolynomialOperator_NotEquals_When_Second_Argument_is_Null_ExceptionReturned(double[] coefficients)
        {
            Polynomial polynomial1 = new Polynomial(coefficients);
            Polynomial polynomial2 = null;
            bool b;
            Assert.Throws<ArgumentNullException>(() => b = polynomial1 != polynomial2);
        }
        [Test]
        [TestCase(new[] { 0d, 1d, 2d, 3d })]
        public void PolynomialOperator_NotEquals_When_First_Argument_is_Null_ExceptionReturned(double[] coefficients)
        {
            Polynomial polynomial1 = null;
            Polynomial polynomial2 = new Polynomial(coefficients);
            bool b;
            Assert.Throws<ArgumentNullException>(() => b = polynomial1 != polynomial2);
        }
        [Test]
        [TestCase(null, null, ExpectedResult = false)]
        public bool PolynomialOperator_NotEquals_NullArguments_FalseReturne(Polynomial polynomial1, Polynomial polynomial2)
        {
            return polynomial1 != polynomial2;
        }
        #endregion

        
        [TestCase(new double[0])]
        public void Constructor_ArgumentExceptionReturned(double[] coefficients)
        {
            Assert.Throws<ArgumentException>(() => new Polynomial(coefficients));
        }
        
        [TestCase(null)]
        public void Constructor_ArgumentNullExceptionReturned(double[] coefficients)
        {
            Assert.Throws<ArgumentNullException>(() => new Polynomial(null));
        }
        
        [TestCase(new double[] { 0, 1, 2, 3 }, ExpectedResult = "(0x^3) + (1x^2) + (2x^1) + (3)")]
        [TestCase(new double[] { 0, 0, 0, 0 }, ExpectedResult = "(0x^3) + (0x^2) + (0x^1) + (0)")]
        [TestCase(new double[] { 1.5, 0, -2, 3.78 }, ExpectedResult = "(1,5x^3) + (0x^2) + (-2x^1) + (3,78)")]
        public string ToString_ConverDouble_ToPolynomialString(double[] coefficients)
        {
            Polynomial polynomial = new Polynomial(coefficients);

            return polynomial.ToString();
        }
    }
}