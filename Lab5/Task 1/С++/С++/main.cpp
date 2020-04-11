#include <iostream>
#include "Line.hpp"
#include "Segment.hpp"

using namespace std;

int main(int argc, const char * argv[]) {
    double* start = new double[3] {0., 1000., 0.};
    double* end = new double[3] {0., 0., 0.};
    Segment ln = Segment(start, end);
    cout << ln.GetXAngle() << endl;
    cout << ln.GetLength() << endl;
}
