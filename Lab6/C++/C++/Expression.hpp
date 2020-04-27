#ifndef Expression_hpp
#define Expression_hpp

#include <stdio.h>

class Expression {
    private:
        double _a, _c, _d;
    public:
        Expression(double, double, double);
        double Calculate();
};

#endif /* Expression_hpp */
