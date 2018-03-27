using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._05
{
    public class Polynomial
    {
        #region fields
        private double[] coefficients = new double[] { };

        #endregion

        #region constructor
        public Polynomial(double[] coefficients)
        {
            if (coefficients is null)
                throw new ArgumentNullException($"Argument {nameof(coefficients)} must be not null");
            if (coefficients.Length == 0)
                throw new ArgumentException($"Argument {nameof(coefficients)} length must be greater than zero ");
            this.coefficients = coefficients;
        }
        #endregion

        #region properties
        public int Count
        {
            get { return coefficients.Length; }
        }
        public double this[int n]
        {
            get { return coefficients[n]; }
            set { coefficients[n] = value; }
        }
        #endregion


        #region overrided methods

        public override string ToString()
        {
            string result = string.Empty;
            for (int i = 0, j = this.Count - 1; i < this.Count; i++, j--)
            {
                if (i != coefficients.Length - 1)
                {
                    result += $"({coefficients[i]}x^{j}) + ";
                }
                else
                {
                    result += $"({coefficients[i]})";
                }
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj is null && this is null)
                return true;
            if (obj is null || this is null)
                return false;
            
            if (!(obj is Polynomial))
                throw new ArgumentException($"Argument {nameof(obj)} must have a type of Polynomial");

            if (this.Count != ((Polynomial)obj).Count)
                return false;

            Polynomial input = (Polynomial)obj;

            bool isEqual = true;
            for (int i = 0; i < this.Count && isEqual == true; i++)
            {
                if (input[i] == this[i])
                    isEqual = true;
                else
                    isEqual = false;
            }
            return isEqual;
        }
        public override int GetHashCode()
        {
            int result = 0;

            for (int i = 0, j = this.Count - 1; i < this.Count - 1; i++, j--)
            {
                result += (int)coefficients[i] ^ j;
            }

            return result.GetHashCode();
        }

        #endregion

        #region operators method
        /// <summary>
        /// Compares two polynoms
        /// </summary>
        /// <param name="polynomial1"> The first polynom</param>
        /// <param name="polynomial2"> The secind polynom </param>
        /// <returns> return true if arguments is not equal </returns>
        public static bool operator !=(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 is null && polynomial2 is null)
                return false;
            if (polynomial1 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial1)} must be not null");
            if (polynomial2 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial2)} must be not null");
            return !(polynomial1.Equals(polynomial2));
        }

        /// <summary>
        /// Compares two polynomials
        /// </summary>
        /// <param name="polynomial1"> The first polynom</param>
        /// <param name="polynomial2"> The secind polynom </param>
        /// <returns> return true if arguments is equal </returns>
        public static bool operator ==(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 is null && polynomial2 is null)
                return true;
            if (polynomial1 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial1)} must be not null");
            if (polynomial2 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial2)} must be not null");
            return polynomial1.Equals(polynomial2);
        }

        /// <summary>
        ///adds two polynomials 
        /// </summary>
        /// <param name="polynomial1"> The first polynom</param>
        /// <param name="polynomial2"> The secind polynom </param>
        /// <returns> The polynom (sum of two polynomials) </returns>
        public static Polynomial operator +(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial1)} must be not null");
            if (polynomial2 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial2)} must be not null");

            return Add(polynomial1, polynomial2);
        }

        /// <summary>
        ///subtracts right polynomial from the left polynomial
        /// </summary>
        /// <param name="polynomial1"> The first polynom</param>
        /// <param name="polynomial2"> The second polynom </param>
        /// <returns> The polynom (substraction of two polynomials) </returns>
        public static Polynomial operator -(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial1)} must be not null");
            if (polynomial2 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial2)} must be not null");
            return Substract(polynomial1, polynomial2);
        }

        /// <summary>
        /// myltiply left and right polynoms
        /// </summary>
        /// <param name="polynomial1"> The first polynom </param>
        /// <param name="polynomial2"> The second polynom </param>
        /// <returns> The polynom (myltiplication of two polynomials) </returns>
        public static Polynomial operator *(Polynomial polynomial1, Polynomial polynomial2)
        {
            if (polynomial1 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial1)} must be not null");
            if (polynomial2 is null)
                throw new ArgumentNullException($"Argument {nameof(polynomial2)} must be not null");

            return Multiply(polynomial1, polynomial2);
        }
        #endregion


        #region privatepart
        private static Polynomial Add(Polynomial polynomial1, Polynomial polynomial2)
        {
            double[] coeffPolynomial1 = new double[polynomial1.Count];
            double[] coeffPolynomial2 = new double[polynomial2.Count];

            coeffPolynomial1 = polynomial1.coefficients.Reverse().ToArray();
            coeffPolynomial2 = polynomial2.coefficients.Reverse().ToArray();

            int resultLength = Math.Max(coeffPolynomial1.Length, coeffPolynomial2.Length);
            var result = new double[resultLength];

            for (int i = 0; i < resultLength; i++)
            {
                double a = 0;
                double b = 0;

                if (i < coeffPolynomial1.Length)
                {
                    a = coeffPolynomial1[i];
                }
                if (i < coeffPolynomial2.Length)
                {
                    b = coeffPolynomial2[i];
                }
                result[i] = a + b;
            }
            return new Polynomial(result.Reverse().ToArray());
        }

        private static Polynomial Substract(Polynomial polynomial1, Polynomial polynomial2)
        {
            double[] coeffPolynomial1 = new double[polynomial1.Count];
            double[] coeffPolynomial2 = new double[polynomial2.Count];

            coeffPolynomial1 = polynomial1.coefficients.Reverse().ToArray();
            coeffPolynomial2 = polynomial2.coefficients.Reverse().ToArray();

            int resultLength = Math.Max(coeffPolynomial1.Length, coeffPolynomial2.Length);
            var result = new double[resultLength];

            for (int i = 0; i < resultLength; i++)
            {
                double a = 0;
                double b = 0;

                if (i < coeffPolynomial1.Length)
                {
                    a = coeffPolynomial1[i];
                }
                if (i < coeffPolynomial2.Length)
                {
                    b = coeffPolynomial2[i];
                }
                result[i] = a - b;
            }
            return new Polynomial(result.Reverse().ToArray());
        } 

        private static Polynomial Multiply(Polynomial polynomial1, Polynomial polynomial2)
        {
            int Count = polynomial1.Count + polynomial2.Count - 1;
            var result = new double[Count];
            for (int i = 0; i < polynomial1.Count; i++)
            {
                for (int j = 0; j < polynomial1.Count; j++)
                {
                    result[i + j] += polynomial1[i] * polynomial2[j];
                }
            }
            return new Polynomial(result);
        }
        #endregion
    }


}
