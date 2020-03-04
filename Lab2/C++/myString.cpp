#include <cstring>
#include "myString.h"

using namespace std;


char* MyString::getValue() {
    return this->Value;
}

MyString::MyString(char* value) {
    this->Value = value;
}

int MyString::getLength() {
    return strlen(this->Value);
}
