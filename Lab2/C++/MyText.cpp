#include <iostream>
#include <cstring>
#include <vector>
#include "MyText.h"

using namespace std;

void MyText::addString(MyString newString) {
    text.push_back(newString);
    this->size++;
};

void MyText::write() {
   for (MyString i : text) {
       cout << i.getValue() << " ";
   }
   cout << endl;
}

void MyText::removeString(int index) {
    text.erase(text.begin() + index ) ;
};

void MyText::removeString(MyString substring) {
    if (substring.getLength() > 0) {
        char key = substring.getValue()[0];
        for (int i = getLength()-1; i >= 0; i--) {
            for (int j = 0; j < text[i].getLength(); j++) {
                if (text[i].getValue()[j] == key && j + substring.getLength() <= text[i].getLength()) {
                    bool found = true;
                    for (int k = j; k < j+substring.getLength(); k++) {
                        if (text[i].getValue()[k] != substring.getValue()[k - j]) {
                            found = false;
                            break;
                        }
                    }
                    if (found) {
                        removeString(i);
                        break;
                    }
                }
            }
        }
    }
}

double MyText::averageLength() {
    float result;
    int length = 0;
    for (MyString str : text) {
        length += str.getLength();
    }
    result =  length / text.size();
    return result;
}

double MyText::percentOfVowel() {
    const std::string vowel_letters("eyuioa");
    int letters = 0;
    int vowel = 0;
    for (MyString str : text) {
        letters += str.getLength();
        for (int i = 0; i < str.getLength(); i++) {
            if (isVowel(str.getValue()[i])) {
                vowel += 1;
            }
        }
    }
    double percent = (double) vowel / letters * 100;
    return percent;
};

void MyText::eraseText() {
    text.erase(text.begin(),text.end());
}

bool MyText::isVowel(char a) {
    return a == 'e' || a == 'y' || a == 'u' || a == 'i' || a == 'o' || a == 'a' ||
        a == 'E' || a == 'Y' || a == 'U' || a == 'I' || a == 'O' || a == 'A';
}

int MyText::getLength() {
    return this->size;
}
