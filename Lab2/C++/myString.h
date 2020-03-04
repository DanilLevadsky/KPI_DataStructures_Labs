#ifndef LINE_H
#define LINE_H

#include <string>
#include <cstring>

class MyString {
private:
    char* Value;
public:
    explicit MyString(char* value);
    int getLength();
    char* getValue();
};

#endif