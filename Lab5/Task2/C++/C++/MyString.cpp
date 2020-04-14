#include "MyString.hpp"
#include <cstring>

using namespace std;

MyString::MyString(char* str){
    this->Value = str;
}

string MyString::GetValue(){
    return this->Value;
}

int MyString::GetLength() {

    return strlen(this->Value);
}

void MyString::Insert(char elem, uint index) {
    int length = this->GetLength();
    char* newValue = new char[length + 1];
    for (int i = 0; i < length + 1; i++) {
        if ( i < index ) {
            newValue[i] = Value[i];
        }
        if ( i == index ) {
            newValue[i] = elem;
        }
        if ( i > index ){
            newValue[i] = Value[i-1];
        }
    }
    Value = newValue;
}

