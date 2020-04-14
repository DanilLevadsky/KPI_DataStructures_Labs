#ifndef MyString_hpp
#define MyString_hpp

#include <stdio.h>
#include <iostream>
#include <string>

class MyString {
    public:
        std::string GetValue();
        MyString(char*);
        virtual void Insert( char, uint );
    protected:
        virtual int GetLength();
        char* Value;
};

#endif
