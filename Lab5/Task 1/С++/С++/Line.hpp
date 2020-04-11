#ifndef Line_hpp
#define Line_hpp

#include <stdio.h>

using namespace std;

class Line{
    protected:
        double Length;
        double** Coordinates;
        Line(double*, double*);
    private:
        double CalculateLength();
    public:
        double GetLength();
};

#endif
