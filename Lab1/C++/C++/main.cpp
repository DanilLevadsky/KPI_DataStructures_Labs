//
//  main.cpp
//  C++ version of first Laboratory work
//
//  Created by Danil Levadsky on 16.02.2020.
//  Copyright © 2020 Danil Levadsky. All rights reserved.
//

#include <iostream>
#include <string>

using namespace std;

int Addition(int, int);
int Increment(int);
void Increment(int, int&);
bool IfMore(int, int);
void IfMore(int, int, bool&);


int main(int argc, const char * argv[]) {
    cout<<Increment(15)<<endl;
    cout<<Increment(-15)<<endl;
    cout<<Increment(0)<<endl;
    bool a, b, c, d, e;
    IfMore(12, 1, a);
    cout<<boolalpha<<a<<endl;
    IfMore(-12, -7, b);
    cout<<boolalpha<<b<<endl;
    IfMore(-12, -11, e);
    cout<<boolalpha<<e<<endl;
    IfMore(1, 2, d);
    cout<<boolalpha<<d<<endl;
    IfMore(-2, -12, c);
    cout<<boolalpha<<c<<endl;
}

int Addition(int number1, int number2)
{
    while (number2 != 0)
    {
        auto carry = number1 & number2;
        number1 ^= number2;
        number2 = carry << 1;
    }
    return number1;
}

int Increment(int number)
{
    return -~number;
}

void Increment(int number, int& result)
{
    result = -~number;
}

bool IfMore(int number1, int number2)
{
    auto sign = Addition(number1, Addition(~number2, 1)) >> 31;
    return sign == 0;
}


void IfMore(int number1, int number2, bool& result)
{
    auto sign = Addition(number1, Addition(~number2, 1)) >> 31;
    result = (bool)(sign == 0);
}
 
