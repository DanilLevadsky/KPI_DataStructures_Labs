#include "CapitalLetter.hpp"
#include <cstring>

CapitalLetter::CapitalLetter(char* str) : MyString(str) {
    this->Value = new char[strlen(str)];
    for (int i = 0; i < strlen(str); i++){
        this->Value[i] = toupper(str[i]);
    }
} 

void CapitalLetter::Insert(char elem, uint index){
    int length = this->GetLength();
    char* newValue = new char[length + 3];
    for (int i = 0; i < length + 2; i++) {
        if ( i < index ) {
            newValue[i] = Value[i];
        }
        if ( i == index ) {
            newValue[i] = '/';
        }
        if (i == index + 1){
            newValue[i] = toupper(elem);
        }
        if ( i > index + 1){
            newValue[i] = this->Value[i-2];
        }
    }
    newValue[length+2] = '\0';
    this->Value = newValue;
}

int CapitalLetter::GetLength() {
    return strlen(this->Value);
}
