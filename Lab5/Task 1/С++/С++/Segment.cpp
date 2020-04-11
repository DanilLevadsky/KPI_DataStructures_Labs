#include "Segment.hpp"
#include <math.h>

Segment::Segment(double* start, double* end) : Line(start, end){
    this->oXAngle = CalculateXAngle();
}

double Segment::CalculateXAngle(){
    double radians = acos(abs(this->Coordinates[1][0] - this->Coordinates[0][0])/this->Length);
    return radians * 180 / (atan(1) * 4);
}

double Segment::GetXAngle() { return this->oXAngle; }
