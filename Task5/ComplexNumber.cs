using System;
namespace lab1task5
{
    public class ComplexNumber
    {
        #region Initilization
        public double Re = 0, Imag = 0;
        // Конструктор дійсної і уявної частини
        #endregion
        #region Constructors
        public ComplexNumber(double real, double imaginary)
        {
            Re = real;
            Imag = imaginary;
        }
        // Конструктор для дійсної частини
        public ComplexNumber(double real)
        : this(real, 0)
        {
        }
        #endregion
        #region OperatorsOverloading
        // Return A * B.
        public static ComplexNumber operator *(ComplexNumber A, ComplexNumber B)
        {
            return new ComplexNumber(
                A.Re * B.Re - A.Imag * B.Imag,
                A.Re * B.Imag + A.Imag * B.Re);
        }
        // Return A / B.
        public static ComplexNumber operator /(ComplexNumber A, ComplexNumber B)
        {
            ComplexNumber conjugate = new ComplexNumber(B.Re, -B.Imag); // спряжений
            B *= conjugate;

            ComplexNumber numerator = A * conjugate;

            return new ComplexNumber(
                numerator.Re / B.Re,
                numerator.Imag / B.Re);
        }
        #endregion
        #region ToStringOverride
        public override string ToString()
        {
            return (String.Format("{0} + {1}i", Re, Imag));
        }
        #endregion
    }
}
