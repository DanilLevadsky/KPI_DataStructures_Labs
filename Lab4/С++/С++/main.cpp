#include <iostream>
#include "Vector.hpp"

using namespace std;

int main() {
    Vector vec1 = Vector();
    vec1.VectorInfo();
    Vector vec2 = Vector(5.0, 12.0, 0.0);
    vec2.VectorInfo();
    Vector vec3 = Vector(Vector(3, 3, 3));
    vec3.VectorInfo();
    vec3 = vec3 * 2;
    vec3.VectorInfo();
    vec1 = vec3 - vec2;
    vec1.VectorInfo();
}
