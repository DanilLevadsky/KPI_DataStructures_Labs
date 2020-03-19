#include <iostream>
#include "Vector.hpp"
#include <stdio.h>
#include <math.h>

//return vector`s length
double Vector::GetLength() {
    return sqrt(pow(this->XCoord, 2) + pow(this->YCoord, 2) + pow(this->ZCoord, 2));
}

// return a massive with vector`s coordinates (x, y, z)
double* Vector::GetCoord() {
    double* coord = new double[3] {this->XCoord, this->YCoord, this->ZCoord};
    return coord;
}

// default constructor, null-vector
Vector::Vector() {
    this->XCoord = 0.0;
    this->YCoord = 0.0;
    this->ZCoord = 0.0;
    this->Length = GetLength();
}

// constructor with parameters(coordinates of vector)
Vector::Vector(const double x, const double y, const double z) {
    this->XCoord = x;
    this->YCoord = y;
    this->ZCoord = z;
    this->Length = GetLength();
}

// copy of another vector
Vector::Vector(const Vector &vector){
    this->XCoord = vector.XCoord;
    this->YCoord = vector.YCoord;
    this->ZCoord = vector.ZCoord;
    this->Length = vector.Length;
}

//printing info about vector
void Vector::VectorInfo() {
    std::cout << "Vector`s length: " << this->Length << std::endl;
    printf("Vector`s coordinates: (%f, %f, %f)", GetCoord()[0], GetCoord()[1], GetCoord()[2]);
    std::cout << std::endl;
    std::cout << std::endl;
}

// vector addition
Vector Vector::operator+(Vector &vec){
    Vector newVector;
    newVector.XCoord = this->XCoord + vec.XCoord;
    newVector.YCoord = this->YCoord + vec.YCoord;
    newVector.ZCoord = this->ZCoord + vec.ZCoord;
    newVector.Length = newVector.GetLength();
    return newVector;
}

// vector subtracting
Vector Vector::operator-(Vector &vec) {
    Vector newVector;
    newVector.XCoord = this->XCoord - vec.XCoord;
    newVector.YCoord = this->YCoord - vec.YCoord;
    newVector.ZCoord = this->ZCoord - vec.ZCoord;
    newVector.Length = newVector.GetLength();
    return newVector;
}

// increase vector in X times
Vector Vector::operator*(const double times) {
    Vector newVector;
    newVector.XCoord = this->XCoord * times;
    newVector.YCoord = this->YCoord * times;
    newVector.ZCoord = this->ZCoord * times;
    newVector.Length = newVector.GetLength();
    return newVector;
}

// scalar product
double Vector::operator*(Vector &vec) {
    double sum = 0;
    for (int i = 0; i < 3; i++) {
        sum += (this->GetCoord()[i] * vec.GetCoord()[i]);
    }
    return sum;
}
