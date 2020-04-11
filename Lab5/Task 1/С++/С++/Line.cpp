#include "Line.hpp"
#include <math.h>

using namespace std;

double Line::CalculateLength() {
    double sum = 0.;
    for (int i = 0; i < 3; i++) {
        sum += pow(abs(this->Coordinates[1][i] - this->Coordinates[0][i]), 2);
    }
    return sqrt(sum);
}

Line::Line(double* start, double* end){
    double** Coordinates = new double*[2];
    Coordinates[0] = start;
    Coordinates[1] = end;
    this->Coordinates = Coordinates;
    this->Length = this->CalculateLength();
}

double Line::GetLength() { return this->Length; }
