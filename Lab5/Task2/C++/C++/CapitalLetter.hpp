#ifndef CapitalLetter_hpp
#define CapitalLetter_hpp

#include <stdio.h>
#include "MyString.hpp"

class CapitalLetter : public MyString {
    public:
        CapitalLetter(char* str);
        void Insert(char, uint) override;
        int GetLength() override;
};

#endif
