using System;

namespace CSharp
{
    public class Expression
    {
        private readonly double _a, _c,_d;
        public Expression(double a, double c, double d)
        {
            this._a = a;
            this._c = c;
            this._d = d;
        }

        public double Calculate()
        {
            
            if (this._a >= 4 )
            {
                throw new ArithmeticException("Incorrect logarithmic argument.");
            } 
            if (this._a == 0) 
            {
                throw new DivideByZeroException("Denominator shouldn`t be equal 0.");
            } 
            var result = (2 * this._c - this._d / 23) / Math.Log(1 - this._a / 4); 
            return result;
        }

        
    }
}