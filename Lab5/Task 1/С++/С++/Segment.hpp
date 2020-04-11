#ifndef Segment_hpp
#define Segment_hpp

#include <stdio.h>
#include "Line.hpp"


class Segment : public Line{
    public:
        double GetXAngle();
        Segment(double*, double*);
    private:
        double CalculateXAngle();
        double oXAngle;
};

#endif
