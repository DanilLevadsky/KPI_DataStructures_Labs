#ifndef Vector_hpp
#define Vector_hpp

#include <stdio.h>


class Vector{
    private:
        double XCoord;
        double YCoord;
        double ZCoord;
        double Length;
        double* GetCoord();
        double GetLength();
    public:
        Vector();
        Vector(const double, const double, const double);
        Vector(const Vector&);
        void VectorInfo();
        Vector operator +( Vector& );
        Vector operator -( Vector& );
        double operator *( Vector& );
        Vector operator *( double );
};

#endif
