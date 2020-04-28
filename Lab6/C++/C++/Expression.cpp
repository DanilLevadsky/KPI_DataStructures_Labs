#include "Expression.hpp"
#include <math.h>

Expression::Expression(double a, double c, double d) {
    this->_a = a;
    this->_c = c;
    this->_d = d;
}

double Expression::Calculate() {
    if (this->_a == 0) {
        throw "DivideByZeroException. Denominator shouldn`t be equal 0.";
    }
    if (this->_a >= 4) {
        throw "ArgumentException. Logarithmic argument should be more than 0 and not equal 1";
    }
    double result = (2 * this->_c - this->_d / 23) / log(1 - this->_a / 4);
    return result;
}
