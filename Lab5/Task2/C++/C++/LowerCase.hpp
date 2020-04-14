#ifndef LowerCase_hpp
#define LowerCase_hpp

#include <stdio.h>
#include "MyString.hpp"

class LowerCase : public MyString {
    public:
        LowerCase(char* str);
        void Insert(char, uint) override;
        int GetLength() override;
};

#endif
