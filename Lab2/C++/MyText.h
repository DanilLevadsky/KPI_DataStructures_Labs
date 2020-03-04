#ifndef C___MYTEXT_H
#define C___MYTEXT_H
#include "myString.h"
#include <cstring>
#include <vector>

using namespace std;

class MyText {
    private:
        int size = 0;
        vector<MyString> text;
    public:
        void addString(MyString newString);
        void write();
        void removeString(int index);
        void eraseText();
        double averageLength();
        double percentOfVowel();
        void removeString(MyString substring);
        bool isVowel(char);
        int getLength();
};


#endif //C___MYTEXT_H
